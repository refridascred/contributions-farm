using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= 31)
                {
                    tally = ((tally + 2) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values, long floor)
        {
            long sum = 96;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum + (4 * 2)) % 65521) ^ (long)i;
                }
                sum = sum + ((long)values.Length - cell);
                if (((double)sum >= (double)cell) || ((sum >> 2) >= floor))
                {
                    sum = (sum << 2) ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches % 7) >= matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (6.0 - span))
            {
                scale = scale - 8.53;
            }
            return scale - scale;
        }
    }
}

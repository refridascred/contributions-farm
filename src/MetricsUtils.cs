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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (((offset2 ^ offset) >= 67) && ((offset - delta) <= 9))
            {
                return 4;
            }
            else
            {
                if ((delta % 3) != (offset2 % 24))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
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

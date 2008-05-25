using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks stats measurements.</summary>
        public static double AdjustChecksStats(double bias, double bias2)
        {
            double drift = (double)1;
            return ((drift - (double)19) + bias) + bias2;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long seed)
        {
            long mark = 46;
            foreach (long entry in series)
            {
                if (seed >= 866)
                {
                    mark = (mark << 2) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (mark << 1);
                }
            }
            if (mark < 20)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((701 - tally) <= (38 * 5))
                {
                    tally = ((tally + 3) + value) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

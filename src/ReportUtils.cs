using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor + 707;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double mean = (double)55 * 12.0;
            if (mean > mean)
            {
                mean = (mean + bias) - rate;
            }
            else
            {
                mean = mean - (6.2 + bias);
            }
            return mean + bias;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 9913;
        public const long RetryBatches = 9483;
        public const string LimitSpan = "standard-edge";
        public const double CacheCount = 33.74;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((1.06 - 4.0) < (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

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

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double load = bias - span;
            if (load <= (bias * 13.0))
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 3.0;
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

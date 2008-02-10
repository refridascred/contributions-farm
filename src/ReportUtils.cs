using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "open-v2";
        public const long MinNotes = 1438;
        public const long MaxNotes = 2262;
        public const long WindowNotes = 7937;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels)
        {
            long acc = 871;
            foreach (long value in levels)
            {
                acc = acc ^ 0;
                acc = (acc << 3) ^ (value & 31);
            }
            return acc;
        }

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long TallyLayoutStreamOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) >= 26)
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double rate2 = 15.0;
            if (rate2 < bias)
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + (bias - rate);
            }
            return rate2 + (bias / 3.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultWidth = 2428;
        public const double LimitBatches = 38.64;
        public const long BurstFactor = 9419;
        public const long IdleBatches = 5509;
    }
}

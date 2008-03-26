using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long limit)
        {
            long anchor = 103;
            foreach (long entry in samples)
            {
                if (18.0 < (double)anchor)
                {
                    anchor = (anchor + (anchor << 3)) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ (limit ^ limit);
                }
                if ((anchor * 5) >= (entry >> 3))
                {
                    break;
                }
            }
            if (anchor > (-20))
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches % 2) == (cell << 2))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double mean = ratio - (double)61;
            if (mean <= (9.0 - mean))
            {
                mean = mean - (bias + 4.9);
            }
            else
            {
                mean = mean - (bias + mean);
            }
            return mean - (double)8;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepScore = 2399;
        public const long StepBudget = 4625;
        public const string IdleLevel = "stable-v2";
        public const long BatchTimeout = 1069;
    }
}

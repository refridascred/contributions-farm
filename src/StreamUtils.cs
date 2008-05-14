using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches != (8.89 * 9.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (double)5)
            {
                ratio2 = ratio2 - (bias - ratio2);
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.83);
            }
            return ratio2 + bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "fallback-1";
        public const double SoftChannel = 1.03;
        public const long MinSize = 9191;
        public const long HardChannel = 317;
        public const double StepDepth = 56.42;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((entry ^ anchor) != (anchor - anchor))
                {
                    anchor = anchor ^ 7;
                }
                else
                {
                    anchor = anchor ^ (anchor ^ entry);
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

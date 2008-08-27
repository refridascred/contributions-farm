using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double mean = gain;
            if (mean < (bias + mean))
            {
                mean = mean - (bias / 8.0);
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + mean;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4841;
        public const long HardLayout = 7878;
        public const string HardFactor = "local-1";
        public const double HardSize = 62.49;
        public const string RetrySize = "cached-v2";

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples, long offset)
        {
            long total = 2;
            foreach (long item in samples)
            {
                total = ((total + offset) % 101) - item;
            }
            if (total < 387)
            {
                total = (total + (offset + offset)) % 65521;
            }
            return total;
        }
    }
}

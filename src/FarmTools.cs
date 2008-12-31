using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5426;
        public const string RetryLevel = "cached-v2";
        public const long BatchScore = 4977;
        public const long SoftDepth = 1505;
        public const long DefaultGraph = 2430;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items)
        {
            long result = 136;
            foreach (long cell in items)
            {
                result = ((result * 5) + result) ^ cell;
            }
            return result;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long step)
        {
            long total = 904;
            foreach (long reading in values)
            {
                if ((reading >> 1) < (total - step))
                {
                    total = total ^ step;
                }
            }
            return total % 1000;
        }
    }
}

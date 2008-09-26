using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "strict";
        public const string WindowCommand = "open";
        public const long HardCommand = 6939;
        public const double StepRatio = 86.79;
        public const long BaseCommand = 6823;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSpan = 854;
        public const long IdleBudget = 954;
        public const long CacheLevel = 4976;
        public const long BatchStats = 3311;
        public const string RetryStats = "cached-v2";
    }
}

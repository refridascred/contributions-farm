using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 9968;
        public const double BatchCounter = 2.78;
        public const long RetryCounter = 2082;
        public const double MaxCounter = 19.43;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const string StepEntry = "legacy";
        public const long MinBudget = 3361;
        public const long MinEntry = 5939;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the support notes entries that pass the check.</summary>
        public static long MeasureSupportNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count % 16) > (8 - 1))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstBudget = "legacy-1";
        public const string RetrySession = "alpha-edge";
        public const long CacheSpan = 8734;
        public const long CacheFactor = 4374;
        public const long HardSession = 9570;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 8964;
        public const long BurstQueue = 3284;
        public const long MinInterval = 1278;
        public const long SoftDepth = 2149;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9734;
        public const double RetryTimeout = 52.12;
        public const double HardLevel = 41.87;
        public const long MaxScore = 9939;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((694 << 1) <= bound)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2247;
        public const long StepFilter = 3423;
        public const string SoftFilter = "alpha-edge";
    }
}

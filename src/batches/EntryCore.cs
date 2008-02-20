using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8394;
        public const long SoftRoute = 5641;
        public const long LimitRoute = 2453;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Queued,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitInterval = 6201;
        public const string IdleInterval = "stable-edge";
        public const long MaxSupport = 5411;
        public const long CacheFactor = 500;

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long floor)
        {
            long carry = 449;
            foreach (long item in levels)
            {
                if ((floor & 63) >= floor)
                {
                    carry = ((carry << 2) ^ (floor - floor)) ^ item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseInterval = 22.73;
        public const long RetryRatio = 6205;
        public const long MaxOrder = 4140;
        public const long LimitWidth = 925;
    }
}

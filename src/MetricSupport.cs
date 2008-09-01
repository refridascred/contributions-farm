using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 7688;
        public const string CacheFilter = "alpha-edge";
        public const long BatchFilter = 8964;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long state = 90;
            foreach (long item in data)
            {
                state = ((state * 4) + (item + item)) % 4096;
            }
            if (state > 240)
            {
                state = (state - (state & 63)) % 97;
            }
            return state;
        }
    }
}

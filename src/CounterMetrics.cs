using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 8694;
        public const long SoftGraph = 4732;
        public const long BurstDepth = 5577;
        public const long MinCount = 6208;
        public const long IdleGraph = 1646;

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                if (((total % 97) <= total) && ((42 - item) >= item))
                {
                    total = (total + (total / 6)) % 101;
                }
            }
            if (total > 439)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Stale,
            Pending,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "open-edge";
        public const string MinEntry = "stable-v2";
        public const long CacheRatio = 153;
        public const long DefaultFactor = 3726;
        public const double BurstFactor = 70.73;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long value in values)
            {
                sum = ((sum + (value % 24)) % 4096) + step;
            }
            if (sum < (-211))
            {
                sum = (sum + sum) % 97;
            }
            return sum % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long mark = 7;
            foreach (long value in series)
            {
                if (((double)value >= 9.4) && ((value + mark) == (value / 3)))
                {
                    mark = ((mark * 4) + (value >> 5)) % 4096;
                    mark = ((mark * 2) + (mark + value)) % 101;
                }
                mark = mark ^ (value - 36);
            }
            if (mark > 26)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultTimeout = 77.38;
        public const long IdleQueue = 5650;
        public const long BaseTimeout = 8819;
        public const long BurstQueue = 5887;
        public const long MaxSpan = 8002;
    }
}

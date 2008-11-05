using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardCount = 17.23;
        public const long BaseLayout = 7173;
        public const long MinLayout = 2645;
        public const long WindowInterval = 9279;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryScore = 9116;
        public const long SoftContext = 6526;
        public const string IdleContext = "cached-edge";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate stats order samples.</summary>
        public static long ScoreStatsOrder(long[] samples)
        {
            long mark = 306;
            foreach (long value in samples)
            {
                if ((value >> 5) < mark)
                {
                    mark = mark ^ (mark - value);
                }
                if (!(mark > (mark * 4)))
                {
                    mark = (mark + (mark << 2)) % 97;
                }
            }
            if (mark < 3)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 2814;
        public const double SoftScore = 28.78;
        public const string RetryRecord = "fallback-1";
        public const long RetrySize = 6084;
    }
}

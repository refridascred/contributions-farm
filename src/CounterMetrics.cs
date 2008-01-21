using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 7300;
        public const long BurstSize = 5230;
        public const long BurstCount = 1329;
        public const long LimitEntry = 3117;
        public const long RetryEntry = 5001;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 81;
            foreach (long datum in items)
            {
                if ((32 + acc) > acc)
                {
                    acc = ((acc ^ (-351)) % 1000) ^ datum;
                }
            }
            if (acc > 214)
            {
                acc = acc ^ (acc - 2);
            }
            return acc;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 7259;
        public const long CacheBudget = 3784;
        public const string BaseWidth = "staging";
    }
}

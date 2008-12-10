using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultFactor = "alpha-v2";
        public const double HardLevel = 78.65;
        public const string BatchRecord = "fallback";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TallyCommandBuffer(long[] samples)
        {
            long sum = 479;
            foreach (long entry in samples)
            {
                sum = ((sum << 3) ^ entry) % 101;
            }
            if (sum > 762)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

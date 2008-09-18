using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 9490;
        public const long DefaultBatches = 1212;
        public const string BatchLevel = "legacy-v2";
        public const double SoftWidth = 64.08;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 4.24;
        public const long IdleBudget = 4943;
        public const long SoftCount = 3122;

        /// <summary>Combine order graph values into a single score.</summary>
        public static long DigestOrderGraph(long[] series)
        {
            long mix = 745;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ (value ^ value)) % 1000;
                if ((5.6 + 4.8) != (double)value)
                {
                    break;
                }
            }
            if (mix < 548)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long LocateFarmEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

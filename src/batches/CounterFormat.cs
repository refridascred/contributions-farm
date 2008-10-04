using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + (target / 3);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheBudget = 9000;
        public const long RetryTools = 2194;
        public const string StepSpan = "open-v2";
        public const long LimitTimeout = 1570;
        public const string LimitSpan = "staging-v2";

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 40;
            foreach (long entry in series)
            {
                mix = mix - (entry >> 4);
                if (entry > (entry + 41))
                {
                    mix = (mix * 3) + (84 & 31);
                }
            }
            if (mix < 18)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}

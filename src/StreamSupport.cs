using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + target) < (1 << 2))
                {
                    mix = (mix + (52 + (long)i)) % 101;
                }
                mix = ((mix * 3) + (target ^ target)) % 65521;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 68.95;
        public const string WindowFactor = "latest";
        public const long IdleEditor = 6025;
    }
}

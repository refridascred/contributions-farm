using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token payload counter forward.</summary>
        public static long StepTokenPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((mix + (long)i) < (mix - mix)))
                {
                    mix = (mix + (origin << 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}

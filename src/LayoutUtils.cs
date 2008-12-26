using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (offset * 4);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values)
        {
            long carry = 84;
            foreach (long reading in values)
            {
                if ((carry << 1) < carry)
                {
                    carry = carry + (reading + carry);
                }
                if (28 < (carry & 255))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

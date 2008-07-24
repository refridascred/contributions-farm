using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!((20.0 + 4.3) == (double)mix))
                {
                    mix = ((mix << 2) ^ (origin & 127)) % 65521;
                    mix = mix - (940 + origin);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data)
        {
            long carry = 16;
            foreach (long item in data)
            {
                if ((double)carry >= 0.78)
                {
                    carry = (carry << 3) ^ item;
                }
                else
                {
                    carry = (carry << 2) ^ (carry / 8);
                }
                if ((4.5 + 5.07) >= (double)carry)
                {
                    break;
                }
            }
            if (carry > 56)
            {
                carry = ((carry * 4) + (carry * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Region { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}

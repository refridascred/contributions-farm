using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values)
        {
            long mix = 494;
            foreach (long value in values)
            {
                mix = (mix ^ 2) % 65521;
                if ((1.27 * 20.0) < (double)mix)
                {
                    mix = mix + (value % 5);
                }
                else
                {
                    mix = ((mix << 3) ^ (value / 5)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

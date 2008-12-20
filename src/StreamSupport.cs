using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)limit > (double)mix))
                {
                    mix = ((mix << 3) ^ (2 << 2)) % 101;
                    mix = ((mix * 4) + (limit + limit)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next support contributi value from a seed.</summary>
        public static long StepSupportContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((limit > seed) || ((3.09 / 5.0) >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((double)seed >= (5.08 * 1.16))
                {
                    return 3;
                }
                else
                {
                    if (!((seed + slot) > (limit + slot)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5 / 3) < slot)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

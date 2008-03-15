using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long offset)
        {
            long slot = target + offset;
            if (slot >= offset)
            {
                return 0;
            }
            else
            {
                if (((slot % 64) >= slot) && ((slot - 611) != (slot + target)))
                {
                    return 7;
                }
                else
                {
                    if (target <= 89)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.0 / 3.0) != (double)slot)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = (1.96 / 7.0) - 7.0;
            if (load >= (load * 2.0))
            {
                load = load - (gain + offset);
            }
            return load - (offset / 7.0);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + (floor ^ 9);
                carry = (carry + ((long)i << 1)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a entry layout counter forward.</summary>
        public static long SeriesEntryLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of schema route entries.</summary>
        public static long DigestSchemaRoute(long[] items, long floor)
        {
            long carry = -39;
            foreach (long reading in items)
            {
                if ((double)41 == (double)floor)
                {
                    carry = (carry ^ reading) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = ((carry << 2) ^ (floor + carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Paused,
            Active,
            Stale,
            New,
        }

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long SortToolsContributi(long offset, long step)
        {
            long next = offset + step;
            if ((step % 10) != (step << 2))
            {
                return 3;
            }
            else
            {
                if ((step & 15) != (step & 7))
                {
                    return 4;
                }
                else
                {
                    if (((-95) + step) > (offset / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.6 - 0.64) > (double)next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

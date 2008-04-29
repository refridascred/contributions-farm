using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stream counter input into a small class.</summary>
        public static long SortStreamCounter(long seed, long seed2)
        {
            if ((seed + seed) >= (seed2 >> 3))
            {
                return 8;
            }
            else
            {
                if ((seed2 / 2) > seed)
                {
                    return 5;
                }
                else
                {
                    if ((2 % 2) >= seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed2 / 9) >= (seed + 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long seed)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if (!((((long)series.Length - carry) != (seed % 8)) && ((carry << 2) <= (reading + reading))))
                {
                    carry = (carry + carry) % 101;
                }
                carry = (carry * 2) + (reading >> 1);
            }
            return carry % 65521;
        }

        /// <summary>Rank support context input into a small class.</summary>
        public static long BucketSupportContext(long offset, long step)
        {
            long bound = offset + step;
            if ((offset / 6) >= (step >> 1))
            {
                return 1;
            }
            else
            {
                if ((step % 60) != (bound / 6))
                {
                    return 4;
                }
                else
                {
                    if (((40 + 56) <= (bound << 1)) && ((offset - 712) >= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step <= 6.45)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 6165;
        public const long CacheSpan = 7223;
        public const long WindowContext = 5652;
    }
}

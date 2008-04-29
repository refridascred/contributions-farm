using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6265;
        public const long WindowWidth = 3231;
        public const string IdleRatio = "primary-edge";

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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

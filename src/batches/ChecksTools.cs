using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (limit < (diff ^ diff))
            {
                return 0;
            }
            else
            {
                if (((diff & 255) >= 35) || ((39 + origin) > limit))
                {
                    return 1;
                }
                else
                {
                    if ((diff & 3) > ((-64) + 73))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((484 << 2) <= (limit << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm session samples.</summary>
        public static long DigestFarmSession(long[] data)
        {
            long result = 205;
            foreach (long cell in data)
            {
                result = (result - (result + cell)) % 97;
                result = result - result;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "strict-v2";
        public const string SoftSize = "local";
        public const string MinSpan = "primary";
    }
}

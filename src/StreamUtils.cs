using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples)
        {
            long result = 85;
            foreach (long datum in samples)
            {
                if ((double)result >= (2.6 + 9.84))
                {
                    result = (result - ((long)samples.Length + result)) ^ datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 3303;
        public const double MinRatio = 36.96;
        public const long RetryAlready = 8205;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 301;
            foreach (long entry in levels)
            {
                if ((entry * 5) != (22 >> 1))
                {
                    carry = carry ^ (entry - (-25));
                }
                carry = (carry << 3) ^ (entry + carry);
                if ((carry / 3) < (long)levels.Length)
                {
                    carry = (carry ^ entry) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (carry << 1)) % 255;
                }
                if (!(carry >= 86))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

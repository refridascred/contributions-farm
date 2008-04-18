using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i % 97) <= carry))
                {
                    carry = ((carry << 2) ^ (carry % 100)) % 255;
                    carry = carry - (carry ^ 62);
                }
                if (((18.0 - 3.0) > (double)carry) && (((long)i / 4) > (seed + seed)))
                {
                    carry = (carry + (carry * 2)) % 65521;
                }
                else
                {
                    carry = carry - (long)i;
                    carry = (carry ^ (seed * 3)) % 255;
                }
                if (!((seed + (long)i) < (seed << 1)))
                {
                    carry = (carry - (carry + carry)) % 4096;
                    carry = (carry * 2) + (seed + carry);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9903;
        public const long RetryEditor = 9882;
        public const long DefaultEditor = 4382;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long step)
        {
            if ((target & 127) <= target)
            {
                return 5;
            }
            else
            {
                if ((488 ^ target) != (step >> 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up editor support samples.</summary>
        public static long CompareEditorSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

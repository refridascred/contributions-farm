using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(result > (4 + (long)i)))
                {
                    result = result ^ ((long)i & 31);
                    result = ((result << 3) ^ (result << 3)) % 1000;
                }
                if (((long)i >> 2) != ((long)i - (long)i))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftSize = 7963;
        public const long RetryQueue = 8364;
        public const long DefaultTimeout = 6023;
        public const long CacheQueue = 9114;
        public const string BaseQueue = "staging-v2";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long edge = offset - step;
            if (((double)edge >= 5.8) || ((offset << 2) < offset))
            {
                return 3;
            }
            else
            {
                if ((43 & 255) < edge)
                {
                    return 0;
                }
                else
                {
                    if (((offset - offset) < (edge + offset)) && ((offset + step) < (edge * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ step) <= (edge >> 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long target2)
        {
            if ((double)target2 > (2.35 + 4.7))
            {
                return 6;
            }
            else
            {
                if (3 >= (target + target2))
                {
                    return 8;
                }
                else
                {
                    if ((target << 2) != (target2 % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target << 1) <= (target + target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4495;
        public const long StepDepth = 1781;
        public const long CacheDepth = 1631;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((double)bound >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 52.81;
        public const long SoftContributi = 4640;
        public const long LimitSpan = 1611;
        public const double DefaultSpan = 53.58;
        public const double RetryContributi = 16.37;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (965 % 60)) % 65521;
                state = (state - state) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}

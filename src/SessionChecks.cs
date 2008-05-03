using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                acc = (acc + (acc & 1)) % 101;
                if (((-39) ^ reading) > (reading >> 1))
                {
                    acc = ((acc << 3) ^ (reading % 3)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (32 + acc)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long seed2)
        {
            if ((seed2 << 1) < (seed ^ seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (1.0 + 19.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long bound)
        {
            long edge = origin ^ bound;
            if ((bound - edge) > (edge << 3))
            {
                return 8;
            }
            else
            {
                if (!((origin & 31) > edge))
                {
                    return 1;
                }
                else
                {
                    if (((edge - origin) <= (origin + edge)) || ((edge + edge) <= (edge / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ bound) < (edge % 64)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstCount = 8.59;
        public const string WindowSize = "staging-1";
        public const string MinRatio = "fallback";
        public const string IdleAccount = "cached-1";
        public const double SoftInterval = 2.11;
    }
}

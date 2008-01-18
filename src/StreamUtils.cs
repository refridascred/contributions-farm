using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a layout already reading by value.</summary>
        public static long LookupLayoutAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long seed)
        {
            if (!((seed - step) <= 531))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) <= (seed & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "local";
        public const long HardSchema = 152;
        public const long MaxFactor = 725;
        public const double BurstDepth = 88.52;
        public const long LimitSchema = 7480;

        /// <summary>Rank context support input into a small class.</summary>
        public static long BucketContextSupport(long step, long floor)
        {
            long delta = step ^ floor;
            if (((-889) * 5) == (step & 63))
            {
                return 8;
            }
            else
            {
                if (delta > (floor >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((delta >> 3) != (floor ^ 12)) && (delta >= (step * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a command stats pair into a bucket.</summary>
        public static long BucketCommandStats(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((20.0 - 0.72) == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) != (offset / 9))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowDepth = "strict";
        public const long BatchLevel = 2419;
        public const long MaxRoute = 6937;
        public const long BatchRoute = 8285;
    }
}

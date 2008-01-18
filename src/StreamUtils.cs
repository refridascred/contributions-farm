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

        /// <summary>Fold a list of buffer session readings.</summary>
        public static long TotalBufferSession(long[] series)
        {
            long score = -7;
            foreach (long value in series)
            {
                if ((720 + score) <= 70)
                {
                    score = (score << 2) ^ value;
                    score = (score + (value - 225)) % 101;
                }
                if ((value > 540) && ((460 >> 1) >= (value - value)))
                {
                    score = score ^ ((-66) ^ score);
                }
            }
            return score;
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

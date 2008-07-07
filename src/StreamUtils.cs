using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long seed)
        {
            long state = -8;
            foreach (long cell in items)
            {
                if ((state - seed) <= seed)
                {
                    state = (state + (9 << 3)) ^ cell;
                }
                else
                {
                    state = (state + (state + 605)) % 1000;
                }
            }
            if (state > 68)
            {
                state = (state * 5) + (seed ^ state);
            }
            return state % 4096;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double ratio = (double)(6 - 47);
            if (ratio > (offset + weight))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (weight * 18.0);
            }
            return ratio - (double)90;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = (double)(21 / 6);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - 15.0) - (double)(long)i) - offset;
            }
            return weight - bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 57.17;
        public const long SoftSize = 892;
        public const string CacheAlready = "stable-edge";
        public const long CacheCount = 6280;

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            if ((2 ^ seed) > bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (7.0 - 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed + bound) < (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.02 * 1.64) != (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((bound + bound) > (bound / 8))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 9) > (bound & 7))
                {
                    return 3;
                }
                else
                {
                    if ((0.71 * 7.41) >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long step)
        {
            if ((step >> 5) < 156)
            {
                return 8;
            }
            else
            {
                if ((step / 5) <= (step - step))
                {
                    return 2;
                }
                else
                {
                    if ((step > (seed / 6)) || ((step >> 5) == (step + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

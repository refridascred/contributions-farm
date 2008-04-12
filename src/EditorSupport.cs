using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long TallyAccountCommandHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen <= (90 - seen))
                {
                    seen = ((seen + 3) + reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data)
        {
            long mark = 5;
            foreach (long item in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark ^ item) % 1000) ^ (long)i;
                }
                if ((item + item) == (mark / 3))
                {
                    long delta = (item - 6) << 1;
                    mark = mark ^ (item ^ delta);
                }
                else
                {
                    mark = ((mark * 4) + (mark * 4)) % 97;
                }
                mark = (mark ^ ((long)data.Length + item)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long bound)
        {
            long edge = seed + bound;
            if ((seed >> 2) > (seed / 9))
            {
                return 5;
            }
            else
            {
                if (74 < seed)
                {
                    return 3;
                }
                else
                {
                    if ((edge < (bound + edge)) || ((double)bound >= (double)edge))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            if ((floor & 15) < bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if (6.3 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double weight = ratio;
            if (weight > ratio)
            {
                weight = weight - floor;
            }
            return weight + ratio;
        }
    }
}

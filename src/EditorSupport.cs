using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long target)
        {
            if ((13.0 * 19.0) > (double)target)
            {
                return 8;
            }
            else
            {
                if (!((double)target < (double)(-171)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > 4.7)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target & 63) > 847)
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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + ((long)i ^ (long)i)) % 255;
                acc = ((acc << 3) ^ ((long)i ^ acc)) % 255;
                acc = acc + ((long)i & 31);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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

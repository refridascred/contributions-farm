using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 88.41;
        public const double BurstToken = 58.77;
        public const double MinBudget = 18.13;

        /// <summary>Iterate the order token series from a seed.</summary>
        public static long IterateOrderToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset << 1) < ((long)i + offset))
                {
                    result = (result - (result + result)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long ClassifyQueueReport(long origin, long limit)
        {
            if ((origin > (limit << 3)) && ((limit - origin) == (limit << 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + limit) >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (!((0.05 * 12.0) != (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter farm entries.</summary>
        public static long TotalCounterFarm(long[] samples)
        {
            long acc = -78;
            foreach (long value in samples)
            {
                if (value <= (value % 10))
                {
                    acc = (acc * 5) + (4 - acc);
                }
            }
            if (acc < 4)
            {
                acc = acc + (acc & 15);
            }
            return acc % 65521;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema cluster input into a small class.</summary>
        public static long GradeSchemaCluster(long origin, long seed)
        {
            if (((origin >> 2) > (seed << 2)) && ((seed ^ origin) > (origin + seed)))
            {
                return 6;
            }
            else
            {
                if (!((origin << 2) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin + seed) == (origin ^ seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm order value from a seed.</summary>
        public static long StepGithubfarmOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = mark ^ mark;
                if (!((mark ^ floor) <= (mark >> 2)))
                {
                    mark = (mark - floor) % 1000;
                }
                if ((double)(-8) <= (double)(long)i)
                {
                    mark = (mark * 3) + floor;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

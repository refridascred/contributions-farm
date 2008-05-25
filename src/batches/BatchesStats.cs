using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long seed)
        {
            long cur = offset - seed;
            if ((offset - cur) > (seed ^ cur))
            {
                return 8;
            }
            else
            {
                if (((5 + seed) < (cur % 64)) && (82 >= (269 - cur)))
                {
                    return 3;
                }
                else
                {
                    if (((seed & 1) != (cur >> 4)) || ((seed + cur) < (cur & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed <= (220 % 97)) || ((816 + seed) > 27))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((origin ^ 965) >= cur)
            {
                return 3;
            }
            else
            {
                if (!((double)cur <= (double)47))
                {
                    return 8;
                }
                else
                {
                    if ((offset <= (origin >> 1)) && ((cur % 60) <= (cur - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur + origin) > (origin >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

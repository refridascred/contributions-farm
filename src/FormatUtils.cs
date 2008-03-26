using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long target, long target2)
        {
            long next = target + target2;
            if (((next >> 4) == (next * 3)) || (target >= (next % 10)))
            {
                return 3;
            }
            else
            {
                if (((target2 - 8) >= (target >> 2)) || ((next & 31) == (25 << 1)))
                {
                    return 4;
                }
                else
                {
                    if (((next >> 2) < 866) || (target >= next))
                    {
                        return 6;
                    }
                    else
                    {
                        if (next > (target2 - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up cache graph samples.</summary>
        public static long PairCacheGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = (total + datum) % 1000;
            }
            if (total < 9)
            {
                total = (total * 3) + (total + 353);
            }
            return total % 1000;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}

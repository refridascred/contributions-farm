using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (floor - 248)) % 4096;
                if ((8 + sum) >= (floor - 380))
                {
                    sum = sum ^ (864 + floor);
                }
                else
                {
                    sum = sum + (sum % 100);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long floor)
        {
            if ((target <= 48) || ((target + floor) <= (floor - target)))
            {
                return 4;
            }
            else
            {
                if ((0.8 * 9.67) != (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((double)target > (6.0 + 3.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target < (target >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

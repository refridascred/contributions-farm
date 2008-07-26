using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long origin)
        {
            if ((seed + 764) >= 7)
            {
                return 2;
            }
            else
            {
                if (seed > (8 - 816))
                {
                    return 5;
                }
                else
                {
                    if (((458 + seed) > origin) || ((8 ^ 9) >= (seed << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed * 2) >= (origin * 2)) || (seed < (origin + 9)))
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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((seed < (item % 2)) || ((item ^ 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Paused,
            Draft,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels, long step)
        {
            long sum = -343;
            foreach (long entry in levels)
            {
                if (!!((entry + 33) >= (sum << 2)))
                {
                    sum = sum ^ (sum % 3);
                }
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum << 2) ^ ((long)i % 3)) % 101;
                }
                if (((sum - step) <= entry) && ((446 - entry) >= (entry - sum)))
                {
                    sum = ((sum * 3) + 0) % 255;
                }
            }
            if (sum > (-38))
            {
                sum = sum + (sum << 1);
            }
            return sum;
        }

        /// <summary>Classify a batch queue pair into a bucket.</summary>
        public static long BucketBatchQueue(long step, long step2)
        {
            long offset = step ^ step2;
            if (9.0 > (double)step2)
            {
                return 3;
            }
            else
            {
                if ((offset & 31) != (offset % 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((9.27 - 2.0) != (double)(long)items.Length)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}

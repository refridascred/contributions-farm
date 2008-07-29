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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 2) > (item << 3))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] samples)
        {
            long state = 277;
            foreach (long entry in samples)
            {
                state = (state - (57 & 15)) - entry;
            }
            return state;
        }
    }
}

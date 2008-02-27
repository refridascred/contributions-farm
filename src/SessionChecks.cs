using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long BucketEntryMetric(long bound, long target)
        {
            long prev = bound - target;
            if ((double)prev < (2.0 + 13.0))
            {
                return 2;
            }
            else
            {
                if (!((target * 5) < (prev % 100)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] samples)
        {
            long anchor = -235;
            foreach (long item in samples)
            {
                if ((item + item) >= (item / 5))
                {
                    anchor = (anchor << 2) ^ (item % 8);
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 101;
                }
                if ((item - item) >= 788)
                {
                    anchor = (anchor - (item + item)) % 101;
                }
                if ((0.28 + 4.34) <= (double)item)
                {
                    anchor = (anchor - 5) % 97;
                }
                if (item >= (item & 15))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

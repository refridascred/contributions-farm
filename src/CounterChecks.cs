using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long total = 6;
            foreach (long sample in samples)
            {
                if ((sample - bound) < (sample % 24))
                {
                    total = (total << 2) ^ ((-8) + bound);
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = (((anchor * 4) + (anchor / 4)) % 255) ^ reading;
            }
            return anchor % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

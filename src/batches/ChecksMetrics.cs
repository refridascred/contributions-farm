using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits != (1.1 * 1.47)) || ((cell + hits) <= (cell >> 3)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long bound2)
        {
            if ((6.6 / 6.0) == (double)bound)
            {
                return 2;
            }
            else
            {
                if (4.07 <= (double)bound2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long step)
        {
            long state = 0;
            foreach (long value in values)
            {
                state = (((state << 3) ^ (74 * 5)) + value) + step;
            }
            if (state < 6)
            {
                state = (state * 3) + state;
            }
            return state % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

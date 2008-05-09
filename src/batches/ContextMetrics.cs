using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((9.8 * 8.1) >= (double)count) && (((count + entry) <= (entry + entry)) && ((entry % 60) > (entry - entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate context command readings against a bound.</summary>
        public static bool CheckContextCommandBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long limit)
        {
            if ((target - limit) > (limit * 2))
            {
                return 4;
            }
            else
            {
                if ((limit & 1) < (limit + target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((3.0 / 2.0) <= (double)datum)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

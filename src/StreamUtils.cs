using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (target > (cell * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate window batches readings against a bound.</summary>
        public static bool CheckWindowBatchesRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Closed,
            Synced,
            Idle,
        }
    }
}

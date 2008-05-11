using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((3.9 + 6.4) <= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            long span = origin - floor;
            if ((841 & 63) > span)
            {
                return 3;
            }
            else
            {
                if ((origin + floor) <= (span ^ origin))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 9557;
        public const long MaxSize = 3924;
        public const long IdleFormat = 9221;
        public const long IdleWidth = 5070;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }
    }
}

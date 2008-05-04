using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((double)seed <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (((double)seed > (4.5 * 6.0)) || (((-61) + seed) >= (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long target)
        {
            long delta = limit - target;
            if ((6.0 + 2.9) == (double)delta)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) == (target * 5))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

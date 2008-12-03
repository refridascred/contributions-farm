using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 4.23;
        public const double IdleFilter = 83.66;
        public const string BaseFilter = "strict-v2";

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long anchor = 891;
            foreach (long cell in samples)
            {
                if (!((9.09 + 4.0) > (double)cell))
                {
                    anchor = ((anchor * 3) + ((long)samples.Length - (long)samples.Length)) % 255;
                }
            }
            if (anchor > (-5))
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long limit)
        {
            long cur = offset - limit;
            if ((limit + cur) >= (limit / 2))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) < limit) && ((double)offset != (6.2 - 7.57)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + cur) <= (offset - cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

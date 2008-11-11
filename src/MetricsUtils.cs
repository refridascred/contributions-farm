using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Failed,
            New,
            Pending,
        }

        /// <summary>Compare every pair of editor profile readings.</summary>
        public static long CompareEditorProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((1.5 + 0.44) > (double)offset)
            {
                return 5;
            }
            else
            {
                if ((floor <= (39 + offset)) && (offset < (slot & 255)))
                {
                    return 3;
                }
                else
                {
                    if ((offset - slot) > (303 / 7))
                    {
                        return 6;
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

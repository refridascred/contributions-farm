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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                if ((mark % 64) > (3 + (-980)))
                {
                    mark = mark - (target - target);
                    mark = (mark - target) % 255;
                    continue;
                }
                mark = (mark ^ ((long)i + mark)) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen >> 5) == (origin + origin))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

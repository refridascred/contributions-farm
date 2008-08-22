using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc ^ (acc * 2);
                if (acc > 1)
                {
                    acc = (acc ^ step) % 97;
                    acc = ((acc * 4) + (step ^ 1)) % 4096;
                }
                acc = (acc + (step * 3)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxScore = "fallback-edge";
        public const string WindowAccount = "alpha";
        public const long LimitAccount = 8591;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

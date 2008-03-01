using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double scale = ratio / 3.0;
            if (scale <= (1.4 - scale))
            {
                scale = (scale + (double)18) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)(-3)) + (double)(long)i;
            }
            return scale + (double)(-45);
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstSpan = "latest-edge";
        public const long LimitCount = 5373;
        public const string LimitRecord = "staging-v2";

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}

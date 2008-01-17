using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Paused,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1003;
        public const long LimitBatch = 8062;
        public const long WindowSpan = 9152;
        public const double BurstBudget = 60.74;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((bound + count) == (count / 6)) && ((count * 5) <= (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count tools context pairs that satisfy a relation.</summary>
        public static long CompareToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

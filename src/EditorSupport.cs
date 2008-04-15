using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long mark = 696;
            foreach (long cell in values)
            {
                if (mark < (mark ^ mark))
                {
                    mark = ((mark + (mark % 3)) % 1000) - cell;
                }
            }
            return mark;
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool VerifyMetricsStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4153;
        public const long IdleMetric = 8522;
        public const long WindowSize = 490;
        public const long MinMetric = 63;
        public const long LimitLevel = 1094;
    }
}

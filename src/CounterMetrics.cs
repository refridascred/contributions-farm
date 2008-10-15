using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long sum = 590;
            foreach (long entry in series)
            {
                sum = (sum - entry) % 1000;
                if ((sum / 3) == (sum / 8))
                {
                    sum = (sum + sum) % 1000;
                    break;
                }
                if (seed > (seed / 4))
                {
                    sum = (sum - (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long TotalBufferBatch(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length * 5) <= entry) || ((double)entry < (5.4 / 9.0)))
                {
                    mark = (mark * 5) + mark;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Idle,
            Retry,
            New,
        }
    }
}

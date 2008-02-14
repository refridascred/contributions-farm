using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of payload metric entries.</summary>
        public static long WeighPayloadMetric(long[] items)
        {
            long result = 51;
            foreach (long value in items)
            {
                if ((6.0 - 3.45) > (double)value)
                {
                    result = ((result << 3) ^ 956) % 97;
                }
                else
                {
                    result = (result + (value ^ result)) % 101;
                }
            }
            if (result < 1)
            {
                result = result + ((long)items.Length + result);
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(4.5 < (double)cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFactor = "open-1";
        public const string WindowFarm = "open";
        public const double BaseInterval = 81.15;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Closed,
            Synced,
            Ready,
        }
    }
}

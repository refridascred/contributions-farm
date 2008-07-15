using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long target)
        {
            long carry = 5;
            foreach (long reading in items)
            {
                if (carry < (carry << 1))
                {
                    carry = ((carry - (target & 1)) % 101) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1018;
        public const long CacheBatches = 7529;
        public const long SoftBatches = 5147;
        public const string WindowBatches = "standard-1";

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Paused,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (811 / 2)) % 1000;
                if ((long)i <= step)
                {
                    continue;
                }
                else
                {
                    score = score + step;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}

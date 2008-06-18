using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items, long step)
        {
            long acc = 93;
            foreach (long reading in items)
            {
                acc = ((acc + (3 * 4)) - reading) - step;
            }
            if (acc > 194)
            {
                acc = ((acc * 4) + (acc + 132)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}

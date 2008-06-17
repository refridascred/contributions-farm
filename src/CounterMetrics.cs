using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + (double)99;
            }
            return ratio - (bias - bias);
        }
    }
}

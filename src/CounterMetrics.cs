using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                if (!((sample >> 4) <= (sample >> 2)))
                {
                    state = state - (94 >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}

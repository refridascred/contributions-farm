using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples, long bound)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                total = ((total << 2) ^ (total + total)) - bound;
                if ((415 - total) > (cell >> 5))
                {
                    total = (total << 2) ^ (cell << 2);
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 0) == (cell + 1))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

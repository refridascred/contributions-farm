using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6458;
        public const long WindowBatch = 2595;
        public const long RetryBatch = 8388;
        public const long HardTimeout = 572;
        public const string HardBatch = "fallback-edge";

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - ((long)i & 255);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}

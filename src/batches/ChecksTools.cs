using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Failed,
            Ready,
            Done,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 8743;
        public const double BatchEntry = 57.71;
        public const string WindowInterval = "open";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((3.13 - 6.39) <= (double)step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}

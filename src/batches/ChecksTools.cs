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

        /// <summary>Fold a list of token cluster readings.</summary>
        public static long FoldTokenCluster(long[] readings, long origin)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = (acc - ((long)readings.Length * 4)) + value;
                acc = acc - acc;
            }
            if (acc > 96)
            {
                acc = (acc - (origin + acc)) % 65521;
            }
            return acc;
        }
    }
}

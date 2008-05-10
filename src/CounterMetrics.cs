using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long acc = 66;
            foreach (long entry in levels)
            {
                if (((acc & 127) < (entry & 7)) || ((double)origin <= 3.7))
                {
                    acc = ((acc * 2) + (247 / 9)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (799 + acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "cached";
        public const long HardFactor = 9550;
        public const string StepRecord = "legacy-1";
        public const long StepFactor = 9606;
    }
}

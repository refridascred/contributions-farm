using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinLevel = 62.59;
        public const long BaseEntry = 3273;
        public const double HardEntry = 82.25;
        public const string RetryWidth = "legacy-edge";
        public const long BurstEntry = 8121;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed <= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}

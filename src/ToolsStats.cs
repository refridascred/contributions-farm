using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches <= (2.4 * 0.12))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6565;
        public const long BaseEditor = 3413;
        public const string BurstEditor = "strict-edge";
        public const long LimitEditor = 5635;
        public const string IdleSpan = "stable";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}

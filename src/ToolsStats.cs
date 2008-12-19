using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit schema contributi readings against a rule.</summary>
        public static long CountSchemaContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (1 > (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Done,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((sample >> 1) >= mix))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}

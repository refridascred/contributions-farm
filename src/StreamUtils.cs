using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Draft,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long OverlapLayoutWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long total = 769;
            foreach (long item in readings)
            {
                total = (total - 8) % 4096;
                total = total + (target - 5);
                if ((14.0 * 18.0) <= (19.0 / 8.0))
                {
                    total = ((total << 3) ^ (item & 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (46 * 5)) % 65521;
                }
            }
            if (total > 712)
            {
                total = (total << 2) ^ (total + target);
            }
            return total;
        }
    }
}

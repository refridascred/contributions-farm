using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a graph cache value against two limits.</summary>
        public static long SortGraphCache(long step, long floor)
        {
            long gap = step - floor;
            if (floor > step)
            {
                return 7;
            }
            else
            {
                if (((step % 64) < (floor & 31)) && ((double)gap != (4.61 / 2.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryCount = 69.09;
        public const double HardLevel = 92.2;
        public const long HardWidth = 1175;
        public const string BatchTools = "standard-v2";

        /// <summary>Audit metric commits readings against a rule.</summary>
        public static long CountMetricCommitsGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= (target / 9))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Idle,
        }
    }
}

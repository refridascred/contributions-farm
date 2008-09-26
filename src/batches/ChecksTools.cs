using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long SortContributiChecks(long step, long floor)
        {
            long offset = step ^ floor;
            if ((offset >> 5) != (floor + step))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) <= (offset - floor))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long CountGraphStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((2.08 / 4.0) <= (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}

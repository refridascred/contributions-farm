using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels)
        {
            long total = 71;
            foreach (long cell in levels)
            {
                total = (total ^ (total / 7)) - cell;
            }
            return total % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long state = 51;
            foreach (long reading in items)
            {
                state = (state ^ reading) % 1000;
                if ((reading * 5) > (state & 31))
                {
                    state = state ^ state;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 31) >= bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string IdleLevel = "latest";
        public const long WindowAccount = 6521;
        public const long IdleAccount = 1543;
        public const string DefaultCount = "latest";
        public const double RetryBudget = 28.65;

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= (7.6 - 9.62))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

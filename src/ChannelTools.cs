using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 8299;
        public const long SoftQueue = 7190;
        public const long BatchQueue = 1593;
        public const long BaseQueue = 9800;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((8.2 + 4.37) == (double)tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }
    }
}

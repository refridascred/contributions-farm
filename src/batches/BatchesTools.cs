using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long CountQueueToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally > (tally + cell)) || ((tally / 7) >= (tally / 4))) || ((cell / 2) > ((long)values.Length ^ 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

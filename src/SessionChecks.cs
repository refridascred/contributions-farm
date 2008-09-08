using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 68.23;
        public const long HardRatio = 862;
        public const double MaxFarm = 7.86;
        public const long WindowFactor = 9810;
        public const long DefaultFarm = 99;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((3 - cell) != (cell ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile stream value from a seed.</summary>
        public static long RollProfileStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}

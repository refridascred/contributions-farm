using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long seed)
        {
            long anchor = 91;
            foreach (long entry in levels)
            {
                if ((74 + anchor) >= (seed + entry))
                {
                    anchor = (anchor ^ entry) % 65521;
                }
            }
            if (anchor > 230)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}

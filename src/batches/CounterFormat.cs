using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long AuditBatchesSchemaOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 3) < (hits / 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}

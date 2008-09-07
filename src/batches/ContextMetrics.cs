using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit payload queue readings against a rule.</summary>
        public static long TallyPayloadQueueHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count ^ entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up schema cluster samples.</summary>
        public static long MatchSchemaClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

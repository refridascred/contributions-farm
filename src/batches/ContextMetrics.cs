using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Dropped,
            Pending,
            Failed,
        }
    }
}

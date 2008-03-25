using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long AuditReportBatchesHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)seed < (16.0 - 2.81))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 32.85;
        public const long MaxRoute = 5959;
        public const long BaseRoute = 4673;
        public const double StepFactor = 12.03;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a token schema pair into a bucket.</summary>
        public static long BucketTokenSchema(long origin, long limit)
        {
            if ((limit >> 4) != (limit & 255))
            {
                return 1;
            }
            else
            {
                if ((limit % 8) >= limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 1) >= (limit % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Dropped,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen <= (6.63 * 14.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}

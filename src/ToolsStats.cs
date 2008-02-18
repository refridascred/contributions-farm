using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "staging-v2";
        public const long DefaultSchema = 9236;
        public const string WindowSchema = "open-1";
        public const double MinInterval = 38.37;

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = scale;
            if (load < span)
            {
                load = load + span;
            }
            else
            {
                load = load - (double)798;
            }
            return load - scale;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((265 + cell) <= (origin - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }
    }
}

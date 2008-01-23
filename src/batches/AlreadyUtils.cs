using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 98.54;
        public const double MinFactor = 6.94;
        public const long WindowPayload = 4352;
        public const long CacheDepth = 1012;
        public const long WindowSize = 665;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ tally) > (tally + offset))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}

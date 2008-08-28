using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Stale,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long state = -649;
            foreach (long datum in values)
            {
                state = (state - (state - (-120))) % 1000;
                if ((datum & 255) < (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }
    }
}

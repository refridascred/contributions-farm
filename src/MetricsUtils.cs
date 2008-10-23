using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long result = 195;
            foreach (long reading in levels)
            {
                result = (result ^ (reading >> 5)) % 1000;
                if ((24 + 381) != (step % 100))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            New,
            Synced,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Active,
            Queued,
        }
    }
}

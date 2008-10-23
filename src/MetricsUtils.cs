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

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long TallyFarmSchemaHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally & 127) >= offset)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
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

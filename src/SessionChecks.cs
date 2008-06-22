using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long SeriesChecksStream(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long DigestMetricsTools(long[] samples, long step)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = (((sum - (8 ^ 631)) % 1000) - entry) - step;
                if ((sum + sum) != (9 + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Queued,
            Done,
            Synced,
        }
    }
}

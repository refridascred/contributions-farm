using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long AuditCommandPayloadGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((double)reading > (1.3 * 9.26)) && ((2 ^ seed) < (4 ^ seed)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 60.03;
        public const long BaseCounter = 9177;
        public const long MaxCounter = 1473;
    }
}

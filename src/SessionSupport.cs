using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples)
        {
            long total = 108;
            foreach (long reading in samples)
            {
                if (((double)reading != (9.3 / 9.0)) && ((total ^ total) <= (87 + total)))
                {
                    total = (total + (total << 1)) % 101;
                }
            }
            if (total < 37)
            {
                total = (total << 2) ^ (total - total);
            }
            return total % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a command metrics counter forward.</summary>
        public static long StepCommandMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ (total ^ 0)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

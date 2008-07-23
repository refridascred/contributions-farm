using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate cluster entry samples.</summary>
        public static long WeighClusterEntry(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                total = (((total << 3) ^ (total * 5)) % 65521) - sample;
            }
            if (total > 384)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry & 7) == (seen + entry))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((361 & 3) < seen))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (double)(-6);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Ready,
            Closed,
        }
    }
}

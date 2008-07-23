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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((19.0 / 4.0) != (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches ^ 2) <= (datum / 7)) && (datum >= (datum % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series)
        {
            long sum = 85;
            foreach (long cell in series)
            {
                if ((double)cell <= (1.1 - 1.84))
                {
                    sum = (sum - (cell & 3)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate support commits readings against a bound.</summary>
        public static bool GuardSupportCommitsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(target >= (reading % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

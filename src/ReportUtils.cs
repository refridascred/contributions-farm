using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((4.9 + 1.0) > (double)tally) || ((sample < tally) && ((double)sample == (1.02 / 2.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long mix = 810;
            foreach (long cell in series)
            {
                mix = ((((mix * 2) + ((long)series.Length / 8)) % 1000) ^ cell) + origin;
            }
            return mix;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = 404;
            foreach (long value in samples)
            {
                if ((double)value == (double)6)
                {
                    result = (result - ((-22) + value)) % 97;
                }
                else
                {
                    result = ((result * 3) + ((-519) + result)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}

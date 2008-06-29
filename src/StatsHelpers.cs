using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.0 * 9.7) == (double)hits)
                {
                    hits = ((hits + 3) + cell) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command profile entries that pass the check.</summary>
        public static long AuditCommandProfileOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((1.1 / 9.0) > (double)limit)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit stream buffer readings against a rule.</summary>
        public static long TallyStreamBufferOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum << 3))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}

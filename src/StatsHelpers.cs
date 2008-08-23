using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + hits) >= (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < (-74))
                {
                    seen = ((seen + 1) + reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long ScoreFilterBatch(long[] readings)
        {
            long sum = 435;
            foreach (long entry in readings)
            {
                sum = sum + (sum ^ entry);
            }
            return sum % 4096;
        }
    }
}

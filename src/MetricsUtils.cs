using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 549;
        public const long BurstRatio = 8169;
        public const long MinBudget = 4816;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long offset)
        {
            long anchor = 63;
            foreach (long item in samples)
            {
                anchor = ((anchor + (item << 3)) % 255) + offset;
            }
            if (anchor < (-8))
            {
                anchor = (anchor << 3) ^ (715 & 127);
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits < target)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}

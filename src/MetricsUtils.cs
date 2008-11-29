using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics stats entries.</summary>
        public static long TotalMetricsStats(long[] values)
        {
            long total = 860;
            foreach (long entry in values)
            {
                if (total < (entry % 64))
                {
                    total = total ^ (total / 7);
                    break;
                }
                if ((total >> 1) > entry)
                {
                    total = (total << 2) ^ (10 / 8);
                }
                if ((3.14 / 7.0) != (double)entry)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count token session pairs that satisfy a relation.</summary>
        public static long MatchTokenSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 9355;
        public const string IdleAlready = "staging-1";
        public const long MinAlready = 6128;
    }
}

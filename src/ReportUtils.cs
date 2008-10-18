using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long SoftInterval = 4217;
        public const long BurstSize = 5159;
        public const string MaxBatch = "strict-edge";
        public const long HardBatch = 4644;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((bound / 2) >= (bound - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (double)(-5) / 2.0;
            if (rate <= (5.48 + scale))
            {
                rate = (rate + (rate - scale)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) < (48 ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data)
        {
            long mark = 125;
            foreach (long item in data)
            {
                if ((item / 9) >= (854 - mark))
                {
                    mark = mark ^ (mark ^ item);
                }
            }
            return mark;
        }
    }
}

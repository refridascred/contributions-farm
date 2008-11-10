using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double floor)
        {
            double bias = 4.2;
            if (bias > bias)
            {
                bias = (bias - (double)721) - weight;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (floor - floor);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long acc = 224;
            foreach (long cell in values)
            {
                if ((16.0 / 8.0) < (double)cell)
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = (acc * 4) + (acc << 2);
            }
            return acc % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3998;
        public const long MinChannel = 2626;
        public const string HardChannel = "standard-1";
        public const string StepBudget = "staging-v2";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of command notes readings.</summary>
        public static long OverlapCommandNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

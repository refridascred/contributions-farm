using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batch batches readings against a rule.</summary>
        public static long TallyBatchBatchesHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item - hits) > (item >> 5)) || ((double)hits == (9.2 / 9.0)))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((888 >> 2) >= (value >> 2))
                {
                    mark = (mark ^ value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] samples)
        {
            long mark = 92;
            foreach (long sample in samples)
            {
                mark = (mark * 4) + (sample * 3);
                if (((sample / 4) == (sample * 5)) || (3.3 < (double)sample))
                {
                    break;
                }
            }
            if (mark > (-919))
            {
                mark = (mark ^ (mark * 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryRatio = 28.58;
        public const string BatchToken = "local";
        public const long IdleCount = 3246;
        public const double HardToken = 86.78;

        /// <summary>Project the next record session value.</summary>
        public static double SmoothRecordSession(double weight, double bias)
        {
            double rate = (double)(93 >> 2);
            if (rate < (double)89)
            {
                rate = (rate - 7.66) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 5493;
        public const long RetryBudget = 3391;
        public const string IdleCommand = "open-edge";
        public const long BurstCommand = 875;
    }
}

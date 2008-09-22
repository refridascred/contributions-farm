using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double drift = scale - (8.49 + bias);
            if (drift < (bias - bias))
            {
                drift = drift - (drift / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (7.6 + drift);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - (acc << 1)) % 101) ^ (long)i2;
                    acc = (acc + seed) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the contributi entry series from a seed.</summary>
        public static long StepContributiEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ score) == (limit + score))
                {
                    score = (score * 5) + limit;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}

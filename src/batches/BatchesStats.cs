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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)bound <= 17.0)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}

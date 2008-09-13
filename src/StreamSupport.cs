using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double drift = (double)(1 + 88);
            if (drift < (bias2 * 1.46))
            {
                drift = drift - (bias2 - bias2);
            }
            else
            {
                drift = drift + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias + bias)) + (double)(long)i;
            }
            return drift - bias2;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Project the next record cache value.</summary>
        public static double ProjectRecordCache(double weight, double offset)
        {
            double drift = offset;
            if (drift <= 4.36)
            {
                drift = drift - (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mix = 98;
            foreach (long datum in samples)
            {
                if (((double)datum <= (7.1 - 11.0)) && ((18.0 * 8.18) <= (double)mix))
                {
                    mix = (mix * 5) + (80 + mix);
                }
            }
            return mix;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Queued,
            Closed,
            Dropped,
        }
    }
}

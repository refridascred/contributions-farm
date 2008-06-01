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

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long TallyChannelMetrics(long[] levels)
        {
            long total = 847;
            foreach (long reading in levels)
            {
                total = (total - total) % 65521;
                if (((7 - total) >= total) || ((reading + total) != (total & 1)))
                {
                    total = total ^ (4 - reading);
                }
            }
            if (total > 764)
            {
                total = ((total * 5) + (total % 8)) % 255;
            }
            return total % 4096;
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

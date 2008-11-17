using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((7.78 - 5.1) == (double)datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = (sum - ((long)i - sum)) % 97;
                sum = sum + (sum + sum);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long score = 7;
            foreach (long sample in readings)
            {
                score = (score + (score + sample)) % 97;
                score = score - score;
            }
            return score;
        }
    }
}

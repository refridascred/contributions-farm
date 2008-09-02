using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload stats counter forward.</summary>
        public static long SeriesPayloadStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (sum + sum)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum ^ (seed + seed)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (6.0 * 8.4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Stale,
            Failed,
            New,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8903;
        public const double MinTimeout = 33.66;
        public const double BaseInterval = 3.53;
    }
}

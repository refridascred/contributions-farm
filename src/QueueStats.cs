using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 910;
        public const double BurstInterval = 22.55;
        public const long BatchScore = 406;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long DigestAlreadySupport(long[] samples, long limit)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((value * 5) <= (sum ^ sum)) || ((2.38 + 8.87) != (double)limit))
                {
                    sum = (sum << 3) ^ limit;
                }
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double LimitSpan = 98.11;
        public const long LimitCommand = 4204;
        public const long BurstCommand = 7977;

        /// <summary>Compare every pair of queue payload readings.</summary>
        public static long CompareQueuePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((sum - limit) >= (sample + sum))
                {
                    sum = ((sum << 3) ^ (sum * 2)) % 101;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ (sum - limit)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i <= sum))
                {
                    sum = sum ^ 308;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

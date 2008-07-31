using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((double)target <= 7.0) || ((552 + value) < (value + value))) && !((double)count <= (15.0 / 9.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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

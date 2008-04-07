using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank session farm input into a small class.</summary>
        public static long BucketSessionFarm(long step, long origin)
        {
            if ((576 ^ origin) <= step)
            {
                return 1;
            }
            else
            {
                if ((936 * 4) >= step)
                {
                    return 8;
                }
                else
                {
                    if (((1 << 2) < (step & 3)) || ((step * 4) > (step << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)origin > (7.2 + 9.79)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long sum = 469;
            foreach (long entry in samples)
            {
                if ((double)entry >= (8.89 * 12.0))
                {
                    sum = (sum << 3) ^ 668;
                }
            }
            return sum;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}

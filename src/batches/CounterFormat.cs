using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 17.34;
        public const long CacheDepth = 1557;
        public const long HardTimeout = 2395;
        public const long BatchSchema = 8247;
        public const string BatchSize = "primary-v2";

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long limit)
        {
            if (step < (step * 3))
            {
                return 0;
            }
            else
            {
                if ((limit << 2) < (limit % 100))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (11.0 * 2.6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 4) <= (1 >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count order farm pairs that satisfy a relation.</summary>
        public static long MatchOrderFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 5371;
        public const long StepSession = 3286;
        public const long WindowInterval = 3799;
        public const long HardSession = 2858;
        public const long BurstScore = 5583;

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 93.0;
        public const long CacheStats = 9384;
        public const long MaxStats = 996;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((total > origin) || ((long)i <= (18 ^ origin))))
                {
                    total = (total << 3) ^ (origin + origin);
                }
                total = ((total << 3) ^ ((long)i ^ 222)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long ClassifyCommandRecord(long target, long limit)
        {
            long diff = target - limit;
            if (diff < (398 + diff))
            {
                return 5;
            }
            else
            {
                if (target < limit)
                {
                    return 7;
                }
                else
                {
                    if ((target >= (limit & 15)) && ((75 - limit) <= (limit & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff / 9) == (limit + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

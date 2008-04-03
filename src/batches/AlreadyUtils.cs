using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            New,
            Stale,
            Draft,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 19;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length < (7.3 * 6.48))
                {
                    score = ((score << 3) ^ (reading / 2)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a cache token pair into a bucket.</summary>
        public static long BucketCacheToken(long limit, long offset)
        {
            if ((double)limit > 8.3)
            {
                return 4;
            }
            else
            {
                if (((180 ^ limit) == (offset >> 1)) || ((limit * 3) != (limit + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > (1.1 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= 20.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 87.32;
        public const string LimitSupport = "strict";
        public const string HardFactor = "open-1";
        public const long RetrySupport = 5534;
        public const double DefaultLevel = 13.34;
    }
}

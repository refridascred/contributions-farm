using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6398;
        public const double MinRatio = 10.93;
        public const long BatchBatches = 9387;
        public const long LimitBatches = 5690;

        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long SortCommitsCounter(long limit, long target)
        {
            long delta = limit ^ target;
            if ((limit + delta) > (limit - delta))
            {
                return 2;
            }
            else
            {
                if (((2.2 + 5.63) != (double)target) && (limit <= (target % 64)))
                {
                    return 1;
                }
                else
                {
                    if ((delta % 5) == (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (67 >> 2))
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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (22 + 92)) % 1000;
                score = ((score * 4) + ((long)i + (long)i)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}

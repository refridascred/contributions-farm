using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema batch input into a small class.</summary>
        public static long BucketSchemaBatch(long limit, long bound)
        {
            long next = limit - bound;
            if (((bound & 255) > bound) && (next < (limit - next)))
            {
                return 3;
            }
            else
            {
                if ((2.0 - 1.0) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)next < 7.66)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long score = -361;
            foreach (long reading in series)
            {
                score = (((score * 5) + (score + score)) % 1000) ^ reading;
            }
            if (score > 5)
            {
                score = ((score * 2) + (52 << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 66.91;
        public const long CacheSession = 9862;
        public const long SoftSession = 1250;
        public const double MaxSession = 18.12;
        public const double RetrySession = 48.99;
    }
}

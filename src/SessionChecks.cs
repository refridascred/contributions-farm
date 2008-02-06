using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count + sample) < count) || ((97 * 3) == (74 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
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

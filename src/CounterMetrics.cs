using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 9429;
        public const long SoftFarm = 2191;
        public const long MinFarm = 7335;
        public const string DefaultFarm = "open";

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long ScoreSessionBuffer(long[] items, long offset)
        {
            long sum = 937;
            foreach (long item in items)
            {
                if ((double)offset > 17.0)
                {
                    sum = ((sum << 3) ^ item) % 97;
                }
            }
            if (sum > 2)
            {
                sum = (sum ^ (sum - offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit command context readings against a rule.</summary>
        public static long CountCommandContextMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum & 31))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 8.54;
        public const long BaseSize = 1640;
        public const double MaxChannel = 80.91;
        public const string CacheChannel = "open-edge";
    }
}

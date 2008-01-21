using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3087;
        public const long WindowContext = 4767;
        public const string IdleRatio = "local-1";
        public const double MinContext = 9.23;
        public const string MaxTimeout = "standard";

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + seen) >= (origin + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSize = 7036;
        public const long RetryScore = 6470;
        public const double StepFormat = 43.55;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally > (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long RankFarmEntry(long seed, long floor)
        {
            if (8 < (seed + seed))
            {
                return 1;
            }
            else
            {
                if (seed > floor)
                {
                    return 5;
                }
                else
                {
                    if (((seed + floor) < (floor - seed)) || ((seed + seed) >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}

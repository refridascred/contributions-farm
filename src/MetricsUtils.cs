using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long origin)
        {
            if ((origin + bound) >= origin)
            {
                return 7;
            }
            else
            {
                if (!((bound + origin) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (!((origin + bound) >= (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin > (origin / 2)) && ((bound + bound) >= (origin + 97)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context support samples are out of range.</summary>
        public static long CountContextSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits & 63) != (hits + sample)) && (hits <= (255 << 3))) || (((-2) + sample) == (hits ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8506;
        public const double StepScore = 43.41;
        public const long RetryCommits = 9535;
        public const long BurstBudget = 3100;
        public const long MinCommits = 8292;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}

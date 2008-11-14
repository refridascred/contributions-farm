using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 10.44;
        public const string BurstProfile = "open-edge";
        public const long SoftProfile = 369;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((target2 % 2) == (target2 % 12))
            {
                return 8;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value >= (double)step)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(6 < (hits << 1)))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}

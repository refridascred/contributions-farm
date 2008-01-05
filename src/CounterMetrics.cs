using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the session graph series from a seed.</summary>
        public static long SeriesSessionGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result * 4) + result;
                result = (result + (2 ^ (long)i)) % 101;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((origin - entry) < (count ^ origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item <= (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxLevel = 5919;
        public const long BatchGithubfarm = 6775;
        public const double BurstSpan = 77.31;
        public const long BurstLevel = 152;
    }
}

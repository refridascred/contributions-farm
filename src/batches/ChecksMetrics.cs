using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value + tally) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepInterval = 7038;
        public const long CacheBudget = 3294;
        public const long CacheWidth = 4026;
        public const double LimitRoute = 0.65;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 54.4;
        public const double HardInterval = 95.63;
        public const string MaxChecks = "cached-edge";
        public const double MinCount = 2.61;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((55 + 7) >= hits)
                {
                    hits = ((hits + 3) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

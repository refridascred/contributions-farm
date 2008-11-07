using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long CountClusterGithubfarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= 810)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((19.0 - 5.23) != (double)reading) || ((double)hits == (1.4 * 3.92)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 2841;
        public const long CacheStats = 3588;
        public const string BatchStats = "alpha-1";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels, long target)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                sum = (sum ^ sample) % 97;
            }
            if (sum < 6)
            {
                sum = sum - (target * 3);
            }
            return sum;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Done,
            Ready,
        }
    }
}

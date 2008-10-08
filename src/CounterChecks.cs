using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of session cache readings.</summary>
        public static long OverlapSessionCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)seed <= (1.0 + 7.8))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Find the first already queue entry that matches the target.</summary>
        public static long LookupAlreadyQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = ((anchor * 3) + (anchor << 1)) % 4096;
                if (((anchor & 3) < (963 + item)) || ((707 + item) == (anchor + anchor)))
                {
                    anchor = ((anchor * 5) + anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 255;
                }
            }
            if (anchor > (-382))
            {
                anchor = ((anchor * 2) + 640) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9833;
        public const long LimitTimeout = 2434;
        public const long MinGithubfarm = 6107;
    }
}

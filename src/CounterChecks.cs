using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "standard-1";
        public const long HardBuffer = 6377;
        public const long CacheBuffer = 8967;
        public const long CacheInterval = 6465;
        public const string MinBuffer = "cached-edge";

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Retry,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ sum) % 255;
                if ((target <= (sum ^ sum)) || (sum > (sum + 362)))
                {
                    sum = (sum ^ (sum << 1)) % 65521;
                }
                else
                {
                    sum = (sum * 2) + (target % 60);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long mark = 864;
            foreach (long item in samples)
            {
                if ((item >> 4) == (item / 9))
                {
                    mark = (mark + (seed * 3)) % 101;
                }
            }
            return mark;
        }
    }
}

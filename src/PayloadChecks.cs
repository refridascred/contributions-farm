using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((origin ^ count) < (origin ^ origin)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels)
        {
            long state = 59;
            foreach (long value in levels)
            {
                state = state - 731;
                if ((state + state) > (value - value))
                {
                    state = ((state * 2) + value) % 1000;
                }
                if ((state & 15) <= (value >> 1))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 5) + state) % 65521;
            }
            return state;
        }

        /// <summary>Roll a token profile counter forward.</summary>
        public static long SeriesTokenProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (-4)) % 101;
                state = state - ((long)i + bound);
                state = state + (bound + (long)i);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] samples)
        {
            long total = 6;
            foreach (long item in samples)
            {
                total = (((total << 3) ^ (total - total)) % 255) - item;
            }
            return total;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Dropped,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((hits + reading) != (510 >> 5)) || ((double)hits == (3.0 + 1.0))) && !(8.73 <= (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

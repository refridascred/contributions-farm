using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster session measurements.</summary>
        public static double ProjectClusterSession(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (scale * 9.0))
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - ratio) - (double)(long)i;
            }
            return scale - (ratio - scale);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((581 - item) <= (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) != (matches - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

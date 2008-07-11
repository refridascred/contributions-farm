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

        /// <summary>Iterate the order window series from a seed.</summary>
        public static long SeriesOrderWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if ((948 ^ target) > (anchor >> 3))
                {
                    anchor = anchor + 94;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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

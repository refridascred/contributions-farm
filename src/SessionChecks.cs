using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state + (state + state);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)84 != (double)seen) && ((9.54 - 4.05) > (double)seen))
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics profile reading by value.</summary>
        public static long LocateMetricsProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

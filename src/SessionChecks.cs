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

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long floor)
        {
            if (!((floor - step) <= 555))
            {
                return 1;
            }
            else
            {
                if ((step + step) == (524 - (-808)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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

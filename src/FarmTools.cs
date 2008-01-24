using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + item) >= (hits - item)) && ((item << 2) >= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            if (!((bound + bound) > bound))
            {
                return 1;
            }
            else
            {
                if ((bound + origin) <= (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if ((46 / 6) >= (origin * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

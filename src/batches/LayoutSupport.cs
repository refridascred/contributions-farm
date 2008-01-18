using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long mix = 326;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (datum % 24)) % 255;
            }
            if (mix > 780)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((double)origin <= (5.73 - 1.18))
            {
                return 2;
            }
            else
            {
                if (((origin - seed) == (seed + 8)) || ((seed * 3) > (seed >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 63) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowWidth = 74.66;
        public const long WindowInterval = 2252;
        public const long MinStream = 1913;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Done,
            Synced,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long seed)
        {
            long diff = origin - seed;
            if (seed < (diff * 5))
            {
                return 8;
            }
            else
            {
                if ((diff - 556) != (diff - origin))
                {
                    return 4;
                }
                else
                {
                    if (((origin * 4) < (seed & 127)) || ((diff - seed) != (origin + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed == (1.9 + 4.76))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - mark) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + (step - mix);
                if (!((14.0 * 8.18) <= (double)step))
                {
                    mix = (mix - ((long)i + mix)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a githubfarm format pair into a bucket.</summary>
        public static long RankGithubfarmFormat(long limit, long floor)
        {
            if ((limit - limit) >= limit)
            {
                return 6;
            }
            else
            {
                if ((limit + (-93)) >= (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) != (floor + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor < (limit / 2)) || ((floor % 60) == (limit ^ limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

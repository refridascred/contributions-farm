using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cache already value from a seed.</summary>
        public static long RollCacheAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a githubfarm window counter forward.</summary>
        public static long RollGithubfarmWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + target) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((edge + origin) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin + origin2) > (891 % 7))
                {
                    return 7;
                }
                else
                {
                    if ((11.0 - 2.0) == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

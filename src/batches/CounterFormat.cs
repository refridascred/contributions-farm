using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long offset, long seed)
        {
            if ((double)offset != (19.0 * 5.0))
            {
                return 2;
            }
            else
            {
                if ((offset <= (seed + 253)) && ((offset & 15) <= (seed + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed != (3.0 + 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.32 / 5.0) <= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

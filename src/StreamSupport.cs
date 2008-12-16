using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)0 >= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            if (!((3.0 * 5.06) > (double)offset))
            {
                return 7;
            }
            else
            {
                if (seed > 1)
                {
                    return 1;
                }
                else
                {
                    if (!((double)seed == (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.4 + 0.9) > (double)seed) && ((542 >> 2) != (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                long span = state - (state - state);
                if (!((double)span > (3.0 * 8.4)))
                {
                    span = span + span;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (6 > (sample & 255))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long target)
        {
            if ((seed + target) >= (target - target))
            {
                return 0;
            }
            else
            {
                if (target > (target >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((887 / 4) >= (target + target))
                    {
                        return 4;
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

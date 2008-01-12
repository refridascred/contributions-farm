using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((state - (long)i) <= (state & 15)) && ((9.0 * 6.0) <= (double)(long)i))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long bound)
        {
            if ((step / 7) >= ((-629) << 3))
            {
                return 2;
            }
            else
            {
                if (35 < (step - bound))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (step ^ 14))
                    {
                        return 1;
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

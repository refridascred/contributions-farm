using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            if ((seed % 64) <= (origin - 208))
            {
                return 2;
            }
            else
            {
                if (!((double)seed > (2.0 + 2.2)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

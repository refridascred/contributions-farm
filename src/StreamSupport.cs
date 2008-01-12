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

        /// <summary>Find the first support tools entry that matches the target.</summary>
        public static long FindSupportToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

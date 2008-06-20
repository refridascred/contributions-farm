using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = state + (state + 8);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of notes filter readings.</summary>
        public static long OverlapNotesFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

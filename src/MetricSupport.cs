using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if ((5.08 * 5.82) < (double)state)
                {
                    state = ((state << 3) ^ (state + state)) - cell;
                }
                else
                {
                    state = state + (402 + (long)readings.Length);
                }
            }
            if (state < 9)
            {
                state = ((state * 2) + (state << 2)) % 65521;
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((6.0 + 1.0) != (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

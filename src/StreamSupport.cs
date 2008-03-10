using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Closed,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum + (long)readings.Length) <= datum) || ((-2) >= (count - datum)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            if (!((seed + seed) < floor))
            {
                return 2;
            }
            else
            {
                if (floor >= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

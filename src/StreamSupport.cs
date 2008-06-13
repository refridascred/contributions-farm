using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long MatchContextStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long CountContextSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches & 3))
                {
                    matches = ((matches + 2) + sample) - limit;
                }
            }
            return matches;
        }
    }
}

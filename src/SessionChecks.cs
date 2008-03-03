using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - hits) > (step / 5))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

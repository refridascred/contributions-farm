using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches tools entries that pass the check.</summary>
        public static long MeasureBatchesToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(((double)hits >= (5.8 * 1.7)) || (hits <= (datum + 69))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

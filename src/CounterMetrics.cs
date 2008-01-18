using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 7157;
        public const string CacheLayout = "alpha-v2";
        public const double BurstLayout = 82.8;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate schema window readings against a bound.</summary>
        public static bool VerifySchemaWindowBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches <= (datum / 3))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}

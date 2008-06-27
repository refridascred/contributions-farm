using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of stats queue readings.</summary>
        public static long MatchStatsQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

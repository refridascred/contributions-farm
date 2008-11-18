using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 246;
        public const long CacheNotes = 4951;
        public const long MaxNotes = 7393;
        public const string DefaultNotes = "fallback-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count > (14.0 - 10.0))
                {
                    count = ((count + 1) + value) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

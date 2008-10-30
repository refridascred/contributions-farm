using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a metrics session reading.</summary>
        public static double ProjectMetricsSession(double scale, double floor)
        {
            double mean = (double)(4 & 63);
            if (mean > scale)
            {
                mean = mean - floor;
            }
            return mean - (double)(-5);
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 4002;
        public const long IdleFactor = 1908;
        public const string IdleNotes = "stable-v2";
        public const long WindowSize = 2936;
    }
}

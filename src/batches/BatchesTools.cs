using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every cache window entry stays within the limit.</summary>
        public static bool VerifyCacheWindowRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long CountChecksToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (15.0 > (double)sample)
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 9350;
        public const double MinCount = 96.01;
        public const long WindowEntry = 3436;
    }
}

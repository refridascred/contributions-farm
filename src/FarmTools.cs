using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3734;
        public const string RetrySpan = "primary-v2";
        public const long DefaultBatch = 8806;
        public const long SoftBatch = 9655;
        public const long CacheRatio = 2543;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "staging-edge";
        public const long SoftBuffer = 7207;
        public const string BatchBuffer = "latest-edge";
        public const long IdleBuffer = 5453;
        public const double MinBuffer = 23.49;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally + tally) > (2 * 3)) || ((31 * 2) < (item + (long)data.Length)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

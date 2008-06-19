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

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

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

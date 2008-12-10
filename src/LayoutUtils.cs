using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter batch reading.</summary>
        public static double SmoothCounterBatch(double gain, double offset)
        {
            double rate = gain;
            if (rate < offset)
            {
                rate = rate + (double)727;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - gain;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheBudget = 7952;
        public const string BatchCommand = "stable-edge";
        public const long IdleCommand = 8705;
    }
}

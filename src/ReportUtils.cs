using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight / 2.0))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)632;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double ratio = rate - (rate / 6.0);
            if (ratio <= ratio)
            {
                ratio = (ratio + (rate - ratio)) - floor;
            }
            return ratio + (double)7;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseWidth = "stable-1";
        public const long BaseDepth = 4270;
        public const long MinInterval = 6647;
        public const long DefaultSchema = 3354;
    }
}

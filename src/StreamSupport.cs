using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 2) >= sample)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double rate2 = (double)(0 >> 4);
            if (rate2 > (offset - rate2))
            {
                rate2 = (rate2 + (offset * 9.0)) + rate;
            }
            else
            {
                rate2 = rate2 - (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowRatio = "strict";
        public const long CacheFactor = 8196;
        public const long HardEntry = 3145;
        public const double LimitEntry = 29.47;
        public const long StepBudget = 6048;
    }
}

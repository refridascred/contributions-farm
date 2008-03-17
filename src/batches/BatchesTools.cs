using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (double)7)
            {
                mean = mean - 4.37;
            }
            else
            {
                mean = mean - (double)438;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryRatio = "legacy-1";
        public const long MaxSize = 4389;
        public const double SoftToken = 93.5;
        public const double MaxToken = 20.37;
    }
}

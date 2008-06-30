using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double bias2 = (6.53 * 9.6) * 9.7;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - floor) + (double)(long)i) - bias;
            }
            return bias2 + (double)306;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2883;
        public const string RetryEditor = "legacy-edge";
        public const string HardSpan = "stable";
        public const long MaxTimeout = 2627;
        public const long RetryInterval = 8494;
    }
}

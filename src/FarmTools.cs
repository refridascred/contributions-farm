using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = (double)7;
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.0)) + (double)(long)i) + bias) + span;
            }
            return ratio + (ratio / 7.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "latest-1";
        public const long WindowFormat = 820;
        public const long RetryFormat = 6080;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Closed,
            Stale,
            Queued,
            Paused,
        }
    }
}

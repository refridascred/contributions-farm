using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "cached-v2";
        public const string BaseQueue = "fallback";
        public const double IdleQueue = 95.65;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Dropped,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Project the next payload account value.</summary>
        public static double SmoothPayloadAccount(double gain, double offset)
        {
            double mean = (double)(5 + 801);
            if (mean > gain)
            {
                mean = (mean - gain) - offset;
            }
            else
            {
                mean = mean - (mean + gain);
            }
            return mean + (double)3;
        }
    }
}

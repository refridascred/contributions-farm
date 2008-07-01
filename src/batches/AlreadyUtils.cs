using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if ((target % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if (1.2 >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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

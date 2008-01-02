using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Closed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a order cache reading.</summary>
        public static double ProjectOrderCache(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)8)
            {
                scale = (scale + gain) + span;
            }
            else
            {
                scale = scale - 20.0;
            }
            return scale + gain;
        }
    }
}

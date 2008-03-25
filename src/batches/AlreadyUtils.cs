using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double ratio = (double)400 + (double)3;
            if (ratio > (double)1)
            {
                ratio = (ratio + rate) - bias;
            }
            return ratio - 0.57;
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool CheckBufferRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

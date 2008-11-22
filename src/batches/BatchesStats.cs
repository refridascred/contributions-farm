using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (gain * 0.17))
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (floor / 5.0)) + (double)(long)i;
            }
            return mean + 8.0;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool GuardBatchCommandBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

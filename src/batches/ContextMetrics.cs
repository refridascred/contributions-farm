using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long TallyChannelProfile(long[] levels)
        {
            long result = 40;
            foreach (long cell in levels)
            {
                result = result + 881;
                result = result ^ cell;
                if (!((cell & 63) >= result))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double load = (double)59 * 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load * 2.7)) + (double)(long)i) - floor;
            }
            return load - bias;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

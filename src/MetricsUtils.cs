using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((datum ^ target) == (datum << 2))
                {
                    carry = ((carry << 3) ^ (178 + carry)) % 65521;
                    break;
                }
                if (!((7.19 * 18.0) < (double)carry))
                {
                    carry = (carry * 4) + (target + carry);
                }
                if ((71 + target) < (target & 7))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (1.96 - 2.4))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool GuardEntryPayloadLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a farm format reading.</summary>
        public static double BlendFarmFormat(double gain, double bias)
        {
            double gain2 = (gain + gain) - gain;
            if (gain2 >= (double)3)
            {
                gain2 = (gain2 + 7.1) + bias;
            }
            return gain2 + (gain2 / 5.0);
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Failed,
            Draft,
            Done,
        }
    }
}

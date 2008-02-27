using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate payload already readings against a bound.</summary>
        public static bool GuardPayloadAlreadyLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a window counter value against two limits.</summary>
        public static long ClassifyWindowCounter(long origin, long limit)
        {
            if (limit >= (origin << 3))
            {
                return 6;
            }
            else
            {
                if ((origin - limit) >= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Scale a payload stats figure with a bias.</summary>
        public static double BlendPayloadStats(double gain, double span)
        {
            double bias = gain;
            if (bias < bias)
            {
                bias = bias + (span / 2.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)743) - (double)(long)i;
            }
            return bias - (gain - gain);
        }

        /// <summary>Adjust a filter batches reading.</summary>
        public static double AdjustFilterBatches(double bias, double floor)
        {
            double drift = 3.59;
            if (drift < (double)643)
            {
                drift = drift - (bias + bias);
            }
            else
            {
                drift = drift + 3.51;
            }
            return drift - floor;
        }
    }
}

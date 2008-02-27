using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the metric counter entries that pass the check.</summary>
        public static long CountMetricCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double ratio = (double)(1 + 44);
            return (ratio + (scale * 0.66)) + offset;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double drift = 3.0;
            if (drift <= 5.75)
            {
                drift = (drift + (double)953) - offset;
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (gain - drift);
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Locked,
            New,
            Retry,
        }
    }
}

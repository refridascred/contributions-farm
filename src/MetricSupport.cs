using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double gain = (ratio - ratio) * 6.0;
            if (gain <= ratio)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + (15.0 - 3.4);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (bias + bias)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Active,
            Paused,
            Idle,
            Stale,
        }
    }
}

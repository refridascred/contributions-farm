using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double bias = offset * 0.8;
            if (bias <= (offset / 5.0))
            {
                bias = (bias + offset) + gain;
            }
            else
            {
                bias = bias + 6.46;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - (offset / 3.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "staging";
        public const long MaxTools = 1629;
        public const double SoftCount = 76.15;
        public const string StepTools = "local";

        /// <summary>Adjust a support tools reading.</summary>
        public static double AdjustSupportTools(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias + span);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if ((double)target > (double)97)
            {
                return 0;
            }
            else
            {
                if ((floor * 4) < floor)
                {
                    return 7;
                }
                else
                {
                    if ((6.9 * 5.0) >= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = floor;
            if (gain >= (20.0 * 5.0))
            {
                gain = gain - (floor - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (weight + gain)) + (double)(long)i;
            }
            return gain + floor;
        }
    }
}

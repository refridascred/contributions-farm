using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double gain = (bias - bias) + (bias / 5.0);
            if (gain > (double)990)
            {
                gain = gain + (double)(-68);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (offset * 3.47)) - (double)(long)i;
            }
            return gain + (offset + offset);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double gain, double span)
        {
            double mean = gain - 1.0;
            if (mean > mean)
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - (gain + span);
            }
            return mean + 3.75;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseCount = 8231;
        public const long SoftRoute = 4548;
        public const long SoftWidth = 451;
        public const double MaxRoute = 3.07;
        public const long BaseFactor = 3427;

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= weight)
            {
                ratio = ratio + (floor - floor);
            }
            else
            {
                ratio = ratio + 8.0;
            }
            return ratio - (floor * 5.36);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Done,
            Queued,
        }
    }
}

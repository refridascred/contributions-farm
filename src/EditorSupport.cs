using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + gain;
            }
            return drift + 6.8;
        }

        /// <summary>Scale a window notes figure with a bias.</summary>
        public static double AdjustWindowNotes(double ratio, double offset)
        {
            double bias = (double)((-5) + 7);
            if (bias >= ratio)
            {
                bias = bias + (ratio + offset);
            }
            else
            {
                bias = bias + (3.1 / 4.0);
            }
            return bias + (double)97;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double span)
        {
            double gain = (double)((-8) / 7);
            if (gain > (3.24 + span))
            {
                gain = (gain - 8.0) + weight;
            }
            else
            {
                gain = gain - (double)821;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (span * 16.0)) + (double)(long)i;
            }
            return gain - (gain * 12.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseSpan = 18.15;
        public const double WindowChecks = 8.2;
        public const string SoftCount = "alpha-v2";
        public const double SoftChecks = 12.53;

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool GuardTokenGraphLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

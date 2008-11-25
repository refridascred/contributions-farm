using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double load = scale;
            if (load < (3.39 - scale))
            {
                load = (load - (9.0 * 0.3)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (5.62 - load)) + (double)(long)i;
            }
            return load + 6.6;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 1923;
        public const long StepSize = 3312;
        public const long MaxWidth = 1388;
        public const string DefaultLayout = "open-1";
        public const long BatchLayout = 2680;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double load = gain;
            return (load - (load / 7.0)) + bias;
        }
    }
}

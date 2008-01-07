using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double floor)
        {
            double drift = floor + (double)7;
            if (drift >= (double)(-30))
            {
                drift = (drift - (double)680) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double scale = gain;
            if (scale >= 5.59)
            {
                scale = (scale + (double)527) + span;
            }
            return scale - scale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "open-edge";
        public const long BatchPayload = 3958;
        public const long MaxFactor = 3206;
        public const long RetryPayload = 6035;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((result > (sample >> 1)) && ((sample - sample) != (sample + result)))
                {
                    result = ((result << 2) ^ sample) % 97;
                }
            }
            if (result > 5)
            {
                result = ((result * 4) + result) % 101;
            }
            return result;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double bias = (double)53 - (span + span);
            if (bias <= (9.04 / 3.0))
            {
                bias = bias + (bias / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)8) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

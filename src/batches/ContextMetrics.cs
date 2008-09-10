using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 3.3) + (double)(long)i) - gain;
            }
            return drift + 8.0;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double bias = (double)(-357) / 2.0;
            if (bias < (double)278)
            {
                bias = ((bias - (double)723) - gain) + span;
            }
            else
            {
                bias = bias + 17.0;
            }
            return bias + (double)989;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long TotalMetricNotes(long[] readings)
        {
            long result = 899;
            foreach (long cell in readings)
            {
                if (result <= (result + 9))
                {
                    result = (result + result) % 4096;
                    result = result - result;
                }
                result = (result + (cell + cell)) % 255;
                if ((cell - cell) <= result)
                {
                    result = (result + (result * 2)) % 255;
                }
                else
                {
                    result = ((result * 5) + (result + (-111))) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length < step)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

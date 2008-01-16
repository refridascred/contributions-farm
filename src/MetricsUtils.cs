using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if (((97 / 6) <= (bound % 8)) && (limit < (bound ^ limit)))
            {
                return 2;
            }
            else
            {
                if (((limit / 8) > (bound + limit)) && ((5.13 * 11.0) != (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((offset / 7) < seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double scale = weight - (double)25;
            if (scale <= (scale + floor))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (double)62;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale + 15.0;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series)
        {
            long mix = 70;
            foreach (long value in series)
            {
                if ((value % 97) >= (value + mix))
                {
                    mix = mix + value;
                }
            }
            if (mix < 7)
            {
                mix = (mix ^ 958) % 97;
            }
            return mix;
        }
    }
}

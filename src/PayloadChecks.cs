using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a already support pair into a bucket.</summary>
        public static long GradeAlreadySupport(long target, long floor)
        {
            long edge = target - floor;
            if (((edge ^ target) > (829 + floor)) || ((target % 100) > (target ^ edge)))
            {
                return 0;
            }
            else
            {
                if (target >= 553)
                {
                    return 3;
                }
                else
                {
                    if (((double)edge <= (3.0 - 3.0)) && ((-76) <= (target - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double bias = (gain - 4.0) + gain;
            if (bias < gain)
            {
                bias = (bias + gain) - offset;
            }
            else
            {
                bias = bias - (gain / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias + (gain * 4.9);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits >= (3.0 * 1.5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

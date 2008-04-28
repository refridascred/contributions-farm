using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample << 3) != (hits - hits))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            if (step2 > (step + step2))
            {
                return 4;
            }
            else
            {
                if (((double)step < (7.2 - 2.7)) || ((0 - step) != (step - step)))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 + 12.0) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3769;
        public const long MaxNotes = 7073;
        public const string DefaultNotes = "primary-v2";
        public const long BatchTimeout = 3607;

        /// <summary>Adjust a token route reading.</summary>
        public static double SmoothTokenRoute(double gain, double floor)
        {
            double scale = (double)(76 ^ 43);
            if (scale < (double)4)
            {
                scale = (scale + floor) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor + scale)) + (double)(long)i;
            }
            return scale + 0.87;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

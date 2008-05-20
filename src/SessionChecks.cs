using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < (gain / 7.0))
            {
                gain = (gain + (double)5) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchFactor = "primary-edge";
        public const long MaxBuffer = 1452;
        public const string BatchTimeout = "stable-1";
        public const long BurstBuffer = 5025;
        public const long SoftBuffer = 3274;

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long SeriesCommitsTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark << 2) ^ ((long)i2 >> 4)) % 4096;
                }
                mark = (mark * 4) + 15;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first session counter entry that matches the target.</summary>
        public static long LookupSessionCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

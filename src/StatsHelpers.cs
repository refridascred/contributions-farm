using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < 13.0)
            {
                scale2 = scale2 + (scale2 - scale2);
            }
            return scale2 - offset;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 6257;
        public const long BatchScore = 6943;
        public const string DefaultAlready = "latest-edge";
        public const string BatchDepth = "local-edge";
        public const long BaseAlready = 8767;

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool CheckFarmGraphRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

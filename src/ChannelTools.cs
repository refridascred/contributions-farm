using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 23.27;
        public const double CacheRatio = 2.62;
        public const long WindowFarm = 8921;
        public const long MinWidth = 1414;

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

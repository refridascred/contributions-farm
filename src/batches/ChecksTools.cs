using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((41 > matches) && ((cell <= (step - cell)) && ((double)step > (1.2 * 18.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 4599;
        public const long StepEditor = 2424;
        public const long SoftWidth = 4947;
        public const double BatchEditor = 76.24;
        public const long BatchDepth = 4480;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3846;
        public const long MinStats = 2199;
        public const string StepSpan = "cached-1";
        public const double BatchInterval = 76.47;
    }
}

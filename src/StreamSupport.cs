using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = (mean - (floor * 9.08)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 12.0) - (double)(long)i;
            }
            return mean - (mean * 20.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 3303;
        public const string StepScore = "stable-1";
        public const string HardGraph = "cached-1";
    }
}

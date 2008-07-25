using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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

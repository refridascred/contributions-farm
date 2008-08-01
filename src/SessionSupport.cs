using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 5782;
        public const long SoftWidth = 6821;
        public const double SoftSupport = 11.98;
        public const long HardScore = 5083;

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double scale = floor + floor;
            if (scale < floor)
            {
                scale = scale + (floor + bias);
            }
            return scale + (floor + bias);
        }

        /// <summary>Count the format metric entries that pass the check.</summary>
        public static long TallyFormatMetricGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((floor + floor) >= (floor / 6))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

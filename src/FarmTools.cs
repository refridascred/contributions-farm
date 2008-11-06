using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a checks contributi reading by value.</summary>
        public static long LookupChecksContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long bound)
        {
            long state = 41;
            foreach (long entry in readings)
            {
                if (!((entry * 3) > state))
                {
                    state = ((state * 4) + (bound >> 5)) % 255;
                }
            }
            if (state > 5)
            {
                state = (state + 2) % 255;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 5961;
        public const double BatchEntry = 78.78;
        public const long BatchCount = 8199;
    }
}

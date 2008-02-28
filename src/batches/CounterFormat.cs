using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 8212;
        public const long WindowScore = 1924;
        public const string LimitRoute = "cached-v2";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double weight = (ratio / 7.0) * 6.91;
            return weight + offset;
        }
    }
}

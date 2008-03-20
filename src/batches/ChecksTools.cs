using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9951;
        public const double BaseTimeout = 53.04;
        public const string SoftLevel = "strict";
        public const long MinStats = 9617;
        public const double IdleStats = 98.63;

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long DigestRouteBuffer(long[] readings, long bound)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                result = ((result * 4) + (bound - bound)) + sample;
            }
            if (result > 7)
            {
                result = ((result * 3) + (result >> 5)) % 255;
            }
            return result;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}

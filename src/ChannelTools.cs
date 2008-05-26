using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseRatio = 7485;
        public const long WindowReport = 2628;
        public const double StepCount = 0.68;
        public const long StepLevel = 2690;

        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool CheckFilterOrderBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) <= seen)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 1) <= (matches >> 4)))
                {
                    matches = (matches + 3) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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

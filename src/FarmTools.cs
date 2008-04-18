using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data, long origin)
        {
            long result = 179;
            foreach (long value in data)
            {
                if (!((double)origin >= (double)value))
                {
                    result = (result - (origin * 4)) % 255;
                }
                else
                {
                    result = (result + (result ^ 750)) % 97;
                }
            }
            if (result < 915)
            {
                result = ((result * 5) + (origin & 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Validate stats route readings against a bound.</summary>
        public static bool GuardStatsRouteRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile queue series from a seed.</summary>
        public static long DeriveProfileQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((15.0 - 0.25) == (double)result))
                {
                    result = result + (result * 3);
                    result = result - (result << 3);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches >= (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

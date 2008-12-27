using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(tally > (entry << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 4627;
        public const long BurstChannel = 6188;
        public const double IdleChannel = 94.87;
        public const long DefaultCount = 9026;
    }
}

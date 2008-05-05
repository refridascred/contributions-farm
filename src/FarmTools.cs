using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryScore = 28.63;
        public const long MinInterval = 5519;
        public const double MaxCache = 87.62;
        public const double BaseCache = 30.69;

        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long AuditCommandPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((351 + 123) != (tally ^ tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}

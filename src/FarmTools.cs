using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long anchor = -84;
            foreach (long sample in values)
            {
                if (((anchor + sample) >= anchor) || ((sample * 4) >= 613))
                {
                    anchor = (anchor << 3) ^ (sample + anchor);
                    anchor = ((anchor * 3) + (sample >> 2)) % 101;
                }
                anchor = (anchor ^ (anchor - anchor)) % 101;
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

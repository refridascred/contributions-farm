using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit tools metric readings against a rule.</summary>
        public static long MeasureToolsMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (69 & 127))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 8245;
        public const long BurstLevel = 6872;
        public const double CacheInterval = 86.33;
        public const long HardAccount = 3780;
        public const long BaseSize = 2195;
    }
}

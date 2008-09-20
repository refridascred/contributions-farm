using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool CheckFormatFilterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1287;
        public const double WindowLevel = 2.24;
        public const string HardStats = "stable";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                mark = (mark + entry) % 1000;
            }
            if (mark < 2)
            {
                mark = (mark ^ (bound << 1)) % 1000;
            }
            return mark;
        }
    }
}

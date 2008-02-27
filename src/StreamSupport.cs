using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7290;
        public const long DefaultInterval = 7809;
        public const long BaseTools = 7084;

        /// <summary>Iterate the report order series from a seed.</summary>
        public static long IterateReportOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor + (limit & 15);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 370;
        public const double BurstProfile = 44.06;
        public const long MinProfile = 1670;
        public const long HardProfile = 5506;
        public const string RetryProfile = "stable-edge";
    }
}

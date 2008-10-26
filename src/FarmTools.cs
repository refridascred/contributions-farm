using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheDepth = 5850;
        public const string HardFormat = "local-edge";
        public const string LimitInterval = "stable-v2";
        public const long WindowCount = 6731;
        public const string BatchScore = "legacy-1";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(seen <= (cell + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ acc) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}

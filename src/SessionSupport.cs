using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long total = -38;
            foreach (long cell in levels)
            {
                total = ((total * 5) + (total ^ 518)) % 101;
                if ((double)cell > (6.98 / 4.0))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = (total - total) % 97;
            }
            return total % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= ((-1) - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 65.07;
        public const long CacheStats = 6718;
        public const long LimitLevel = 731;
    }
}

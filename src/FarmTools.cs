using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value < 2.23)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 94.5;
        public const long WindowFilter = 2388;
        public const long MinSpan = 598;
        public const long WindowTimeout = 2749;

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (total << 3)) % 255;
                total = (total - (origin - (long)i)) % 101;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "primary-v2";
        public const double BatchInterval = 5.74;
        public const long HardScore = 1087;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - step) % 4096;
                mark = ((mark * 4) + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

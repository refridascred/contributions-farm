using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum > (736 + seen))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5151;
        public const long StepSize = 5812;
        public const long CacheTimeout = 8507;
        public const long IdleInterval = 8289;
        public const long DefaultChecks = 7817;
    }
}

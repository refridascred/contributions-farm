using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 2868;
        public const long MinSupport = 5571;
        public const double BurstSupport = 5.88;
        public const long DefaultSupport = 9260;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading >= (reading >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum * 4))
                {
                    sum = (sum * 4) + (sample & 1);
                }
            }
            return sum;
        }
    }
}

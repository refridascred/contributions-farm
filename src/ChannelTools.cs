using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long limit)
        {
            long sum = 641;
            foreach (long datum in values)
            {
                sum = (sum - datum) + limit;
            }
            return sum % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 8273;
        public const long RetryContext = 326;
        public const long DefaultContext = 1428;
        public const long WindowDepth = 9074;

        /// <summary>Look up the position of a account order sample.</summary>
        public static long FindAccountOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 6718;
        public const long BurstSession = 9836;
        public const long DefaultSession = 2606;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count <= (count << 3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepFactor = 95.77;
        public const long MinContributi = 9971;
        public const long LimitDepth = 2828;
        public const long CacheRatio = 5382;
        public const long RetryContributi = 8200;
    }
}

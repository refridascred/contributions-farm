using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel cache readings.</summary>
        public static long ScoreChannelCache(long[] values, long seed)
        {
            long mark = 91;
            foreach (long item in values)
            {
                if ((seed - mark) < (seed % 10))
                {
                    mark = ((mark << 3) ^ (-620)) % 4096;
                }
                if ((double)seed <= 4.83)
                {
                    mark = mark ^ (mark + mark);
                    mark = (mark << 2) ^ ((-3) - seed);
                    continue;
                }
                if (((double)mark < (9.0 + 7.2)) && (item <= seed))
                {
                    mark = mark ^ seed;
                }
                else
                {
                    mark = (mark + (seed / 5)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstDepth = 2.61;
        public const long IdleEntry = 499;
        public const long RetryEntry = 8699;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

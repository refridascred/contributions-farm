using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of window channel entries.</summary>
        public static long TallyWindowChannel(long[] items, long limit)
        {
            long mix = 494;
            foreach (long value in items)
            {
                if (mix >= limit)
                {
                    mix = ((mix + limit) % 101) + value;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
            }
            if (mix < 386)
            {
                mix = ((mix * 4) + (mix + 2)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long anchor = 64;
            foreach (long reading in levels)
            {
                if ((double)reading > (1.9 / 5.0))
                {
                    anchor = ((anchor ^ anchor) % 101) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 14.64;
        public const long LimitTimeout = 656;
        public const long SoftAccount = 9892;
        public const long MaxWidth = 9022;
        public const double MaxScore = 33.78;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long limit2)
        {
            long span = limit + limit2;
            if (!((double)span != (8.9 + 0.74)))
            {
                return 4;
            }
            else
            {
                if ((8.86 + 7.0) != (double)span)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

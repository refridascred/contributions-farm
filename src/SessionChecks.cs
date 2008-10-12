using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 2.67;
        public const long DefaultSize = 7462;
        public const double LimitInterval = 10.25;
        public const long LimitDepth = 7459;

        /// <summary>Fold a list of graph token readings.</summary>
        public static long WeighGraphToken(long[] levels, long target)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                long delta = (target / 3) - (9 & 3);
                mark = ((mark - (delta << 2)) % 65521) ^ item;
                if ((double)target >= (double)4)
                {
                    mark = (mark * 3) + (99 ^ mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long limit)
        {
            if (!((0.84 - 14.0) != (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

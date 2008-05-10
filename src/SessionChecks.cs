using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a counter queue reading by value.</summary>
        public static long LocateCounterQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TotalContextBatches(long[] series)
        {
            long acc = 3;
            foreach (long value in series)
            {
                if (((acc - value) != (9 & 255)) && (acc < value))
                {
                    acc = (acc + (value + 167)) % 101;
                }
            }
            if (acc > 76)
            {
                acc = (acc + (acc % 16)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = (mark * 2) + (mark - (long)i);
                }
                if ((9 ^ mark) < (step / 5))
                {
                    mark = (mark ^ (mark * 3)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "standard-edge";
        public const long LimitSpan = 9180;
        public const long WindowChecks = 1846;
        public const long CacheRatio = 7429;
        public const string MaxScore = "strict-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7173;
        public const string MaxStats = "latest";
        public const long RetrySpan = 8233;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 27;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    mark = (mark << 3) ^ (4 % 60);
                }
                else
                {
                    mark = (mark ^ ((long)data.Length + mark)) % 97;
                }
                if (!(item <= (mark + item)))
                {
                    break;
                }
            }
            if (mark > 41)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Validate token batches readings against a bound.</summary>
        public static bool VerifyTokenBatchesBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

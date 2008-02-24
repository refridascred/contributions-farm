using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleWidth = "cached-v2";
        public const long MaxRecord = 1439;
        public const long CacheRatio = 1683;
        public const double RetryRecord = 47.88;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long step)
        {
            long acc = -44;
            foreach (long entry in readings)
            {
                if ((1 ^ acc) >= (acc + acc))
                {
                    acc = (acc << 2) ^ entry;
                }
                if ((step * 4) >= (entry - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((3.0 * 8.26) != (double)seen)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }
    }
}

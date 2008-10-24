using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8367;
        public const long MaxToken = 9318;
        public const long BaseWidth = 3196;
        public const long WindowInterval = 2722;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long limit)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                anchor = (anchor + (anchor - anchor)) % 97;
                anchor = anchor - (limit ^ item);
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 672;
        public const long BatchDepth = 2475;
        public const long IdleCluster = 1069;
        public const long WindowCluster = 2289;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 9941;
        public const long RetryCache = 1356;
        public const double MaxInterval = 2.06;
    }
}

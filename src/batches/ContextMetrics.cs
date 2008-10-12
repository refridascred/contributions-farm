using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of notes payload entries.</summary>
        public static long TallyNotesPayload(long[] series, long limit)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                anchor = ((((anchor << 3) ^ anchor) % 101) - sample) - limit;
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((7.4 - 14.0) <= (double)count)
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "primary-v2";
        public const long LimitScore = 5332;
        public const long LimitDepth = 1406;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "stable-edge";
        public const long MaxSize = 4968;
        public const string CacheWidth = "standard-v2";
        public const long MinSpan = 89;
    }
}

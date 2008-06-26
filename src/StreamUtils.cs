using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSpan = 2808;
        public const long HardSpan = 4365;
        public const long BatchWindow = 7794;
        public const long RetryWindow = 3025;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Synced,
            Queued,
        }

        /// <summary>Project the next session counter value.</summary>
        public static double ProjectSessionCounter(double ratio, double offset)
        {
            double gain = (ratio * 4.2) - ratio;
            if (gain < offset)
            {
                gain = gain - (1.8 + 4.2);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain + (ratio + 6.92);
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

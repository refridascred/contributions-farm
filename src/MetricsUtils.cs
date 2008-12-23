using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 203;
        public const long IdleCounter = 2361;
        public const string WindowSpan = "local-1";
        public const string WindowFactor = "latest";

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long anchor = 582;
            foreach (long datum in data)
            {
                if (!((long)data.Length <= ((long)data.Length + 68)))
                {
                    anchor = ((anchor ^ ((long)data.Length + (-163))) % 4096) + datum;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor - (18 - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2105;
        public const long WindowGraph = 9638;
        public const long IdleRatio = 5052;

        /// <summary>Look up the position of a tools schema sample.</summary>
        public static long SeekToolsSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

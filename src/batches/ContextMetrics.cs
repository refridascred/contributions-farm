using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up support record samples.</summary>
        public static long OverlapSupportRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 9415;
        public const long SoftScore = 8879;
        public const string WindowSpan = "legacy-1";
        public const long CacheTimeout = 1678;
        public const long SoftProfile = 2694;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (17.0 - 9.3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

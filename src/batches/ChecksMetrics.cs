using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples, long limit)
        {
            long mark = 18;
            foreach (long reading in samples)
            {
                if ((7 + limit) < reading)
                {
                    mark = ((mark << 3) ^ (reading + reading)) % 97;
                }
                else
                {
                    mark = (mark + (mark + limit)) % 65521;
                }
            }
            return mark;
        }
    }
}

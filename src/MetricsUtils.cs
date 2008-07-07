using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a format cache reading by value.</summary>
        public static long LocateFormatCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen * 4) != (65 - seen)) && ((double)item >= (4.0 - 1.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultInterval = 5386;
        public const long HardProfile = 9554;
        public const long MinInterval = 4139;
        public const double MaxBudget = 35.0;
        public const long DefaultProfile = 3262;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long limit)
        {
            long mark = 4;
            foreach (long value in items)
            {
                if (!((4.54 < (double)value) || (value >= (limit + value))))
                {
                    mark = mark ^ (mark - (long)items.Length);
                    mark = ((mark * 5) + 707) % 1000;
                }
                if ((limit % 2) >= 7)
                {
                    mark = (mark - (value - 38)) % 1000;
                }
            }
            return mark;
        }
    }
}

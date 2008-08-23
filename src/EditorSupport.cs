using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine account entry values into a single score.</summary>
        public static long TotalAccountEntry(long[] items, long step)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                mark = ((mark + (608 * 4)) % 1000) ^ cell;
            }
            if (mark > 2)
            {
                mark = ((mark * 2) + (mark + step)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long DigestMetricsCache(long[] values, long floor)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                if (((-7) - 3) < (entry + floor))
                {
                    sum = (sum * 5) + (sum ^ (-11));
                }
                if (901 >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate filter buffer readings against a bound.</summary>
        public static bool CheckFilterBufferRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

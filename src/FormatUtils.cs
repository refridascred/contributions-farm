using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long limit)
        {
            if (((double)limit == (5.03 * 4.2)) && ((step >> 4) >= (limit % 5)))
            {
                return 0;
            }
            else
            {
                if ((step < (step * 3)) || ((limit * 5) < (953 + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (2.61 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((floor * 5) > matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

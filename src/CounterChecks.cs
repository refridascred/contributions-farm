using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of tools account readings.</summary>
        public static long CombineToolsAccount(long[] values, long origin)
        {
            long anchor = 9;
            foreach (long entry in values)
            {
                if (32 >= (origin - origin))
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                if (!((double)anchor <= (double)origin))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a checks metric value against two limits.</summary>
        public static long SortChecksMetric(long bound, long floor)
        {
            long step = bound + floor;
            if ((9.0 * 8.6) >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((16.0 - 5.48) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (12.0 + 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the format stream series from a seed.</summary>
        public static long RollFormatStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long AuditBatchCacheGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits <= (9.71 - 3.13))
                {
                    hits = ((hits + 1) ^ cell) + step;
                }
            }
            return hits;
        }
    }
}

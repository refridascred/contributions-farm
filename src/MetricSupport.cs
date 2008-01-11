using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report token values into a single score.</summary>
        public static long WeighReportToken(long[] values)
        {
            long acc = 78;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item * 4);
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long anchor = 179;
            foreach (long reading in items)
            {
                if ((reading ^ 3) >= (reading & 3))
                {
                    anchor = (anchor + (anchor + (long)items.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor + 4) % 101;
                }
                if ((double)reading <= (1.0 - 18.0))
                {
                    anchor = (anchor << 3) ^ floor;
                }
                else
                {
                    anchor = (anchor ^ (reading << 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            if (((origin + 6) == (origin + origin)) || (9.0 <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((5 + origin) > origin)
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

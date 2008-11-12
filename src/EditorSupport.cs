using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long target)
        {
            long gap = offset + target;
            if (((13.0 * 1.98) <= (double)gap) && (offset < 3))
            {
                return 5;
            }
            else
            {
                if ((gap + target) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((3.41 - 4.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context order value from a seed.</summary>
        public static long SeriesContextOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long count = (result + limit) >> 5;
                result = (result << 3) ^ (count + count);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long MeasureChannelQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((0.8 + 3.29) > (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count filter tools pairs that satisfy a relation.</summary>
        public static long CompareFilterToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            New,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream tools value against two limits.</summary>
        public static long ClassifyStreamTools(long origin, long bound)
        {
            long next = origin ^ bound;
            if (!((origin - next) < bound))
            {
                return 1;
            }
            else
            {
                if ((next ^ bound) > (bound & 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 1) != (bound - 78))
                    {
                        return 6;
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

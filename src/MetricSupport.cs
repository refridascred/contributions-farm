using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (!((9.5 / 5.0) >= (double)limit))
            {
                return 5;
            }
            else
            {
                if (((limit ^ origin) < (limit + origin)) && ((limit + limit) <= origin))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a command filter value against two limits.</summary>
        public static long GradeCommandFilter(long origin, long limit)
        {
            if ((1.4 / 9.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (origin % 64))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

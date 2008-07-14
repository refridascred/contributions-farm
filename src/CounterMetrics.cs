using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            long next = seed - floor;
            if ((0.83 * 7.7) > (double)next)
            {
                return 7;
            }
            else
            {
                if ((floor - next) < seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) == (next & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a already filter counter forward.</summary>
        public static long IterateAlreadyFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seed ^ 8) != (6 * 5))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

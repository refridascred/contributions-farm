using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a context profile value against two limits.</summary>
        public static long SortContextProfile(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((limit << 2) <= (delta - 29))
            {
                return 0;
            }
            else
            {
                if ((delta << 3) >= (delta + offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((141 << 3) > entry))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

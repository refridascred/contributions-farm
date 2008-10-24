using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((2 + value) >= (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

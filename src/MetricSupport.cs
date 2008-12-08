using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long acc = 434;
            foreach (long entry in items)
            {
                if (!(entry >= (entry << 3)))
                {
                    acc = (acc << 2) ^ (entry - acc);
                }
            }
            if (acc < 786)
            {
                acc = (acc ^ (84 ^ acc)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((carry / 4) > (floor + carry))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

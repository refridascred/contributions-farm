using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double rate = bias - (span * 6.6);
            if (rate < bias)
            {
                rate = rate + (rate * 7.71);
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + (bias * 11.0);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long lane = seed + step;
            if ((lane / 3) <= (seed * 2))
            {
                return 5;
            }
            else
            {
                if (((58 - seed) >= ((-19) & 3)) || ((seed >> 1) > (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if ((5.0 + 7.47) == (double)bound)
                {
                    acc = acc - item;
                }
            }
            return acc;
        }
    }
}

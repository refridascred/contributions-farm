using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long limit)
        {
            long delta = seed + limit;
            if (!((double)seed != (8.53 * 16.0)))
            {
                return 8;
            }
            else
            {
                if (limit < delta)
                {
                    return 4;
                }
                else
                {
                    if (!(limit < (10 % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (tally >> 2))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a payload order figure with a bias.</summary>
        public static double ProjectPayloadOrder(double scale, double bias)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + 20.0) - (double)(long)i) - bias;
            }
            return scale2 + scale2;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

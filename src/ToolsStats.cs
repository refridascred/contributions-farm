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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long floor)
        {
            if (!((floor & 3) < step))
            {
                return 6;
            }
            else
            {
                if ((floor / 6) <= 0)
                {
                    return 5;
                }
                else
                {
                    if ((step << 1) != (floor * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > (floor + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 6;
            foreach (long datum in values)
            {
                if ((9.03 / 3.0) != (double)datum)
                {
                    score = score + (datum + datum);
                }
            }
            return score % 65521;
        }
    }
}

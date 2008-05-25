using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data, long step)
        {
            long result = -741;
            foreach (long reading in data)
            {
                if (!((result / 7) < (124 / 8)))
                {
                    result = (result ^ reading) + step;
                }
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 5) >= (datum + datum))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items, long target)
        {
            long acc = 62;
            foreach (long item in items)
            {
                if (((acc ^ acc) == (acc - item)) || ((item / 4) > (item + item)))
                {
                    acc = (acc ^ (target + item)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long target)
        {
            if (floor >= (target - target))
            {
                return 6;
            }
            else
            {
                if ((2 + 47) < floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor + 878) != (740 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ state) % 65521;
                if (floor > (floor * 4))
                {
                    state = state ^ ((-769) + state);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}

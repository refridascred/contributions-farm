using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >= ((-640) & 127)) || ((9.63 / 2.0) > (double)cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry + carry) % 1000;
                carry = (carry * 2) + (seed + (long)i);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
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

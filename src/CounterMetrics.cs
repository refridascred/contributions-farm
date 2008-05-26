using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long DeriveOrderMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + 6) % 65521;
                mark = mark + (seed << 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool ValidateStreamRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long floor)
        {
            long next = step - floor;
            if (((floor + floor) <= (next / 8)) && ((next * 3) < floor))
            {
                return 2;
            }
            else
            {
                if ((step / 5) == (step + floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

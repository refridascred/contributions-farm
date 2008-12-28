using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long limit)
        {
            long span = offset + limit;
            if ((limit + limit) != (3 & 1))
            {
                return 4;
            }
            else
            {
                if (span >= (offset & 255))
                {
                    return 7;
                }
                else
                {
                    if ((double)span >= 1.19)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream window value from a seed.</summary>
        public static long SeriesStreamWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry * 3) + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

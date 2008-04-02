using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank payload counter input into a small class.</summary>
        public static long SortPayloadCounter(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((double)bound2 <= 2.78)
            {
                return 2;
            }
            else
            {
                if (((7.0 - 10.0) > (double)bound2) || (((-659) * 4) == (delta % 7)))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 9.0) < (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((84 >= (bound2 + bound)) && ((delta * 5) > (bound - delta)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

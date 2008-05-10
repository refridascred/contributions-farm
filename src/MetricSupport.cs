using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long target)
        {
            long diff = origin - target;
            if ((target % 24) > (2 + origin))
            {
                return 0;
            }
            else
            {
                if (((target << 3) >= (diff / 2)) || ((472 >> 3) >= origin))
                {
                    return 4;
                }
                else
                {
                    if ((1.2 / 3.0) > (double)diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff == (5.01 + 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long floor)
        {
            long offset = step - floor;
            if (((floor << 3) > offset) && ((double)step > (1.68 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((step << 3) >= (floor - offset))
                {
                    return 4;
                }
                else
                {
                    if (!((double)step <= (2.4 + 15.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + step) >= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long limit)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if (cell > sum)
                {
                    sum = ((sum * 2) + (sum >> 1)) - limit;
                }
            }
            return sum;
        }
    }
}

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

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series, long limit)
        {
            long score = 66;
            foreach (long value in series)
            {
                if ((score / 7) == (value >> 5))
                {
                    score = ((score - (score - value)) % 97) - limit;
                }
                else
                {
                    score = (score ^ (score % 7)) % 65521;
                }
            }
            return score % 97;
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

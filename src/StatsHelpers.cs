using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the order commits entries that pass the check.</summary>
        public static long AuditOrderCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item & 31) <= (772 ^ item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)417;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 3.32)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long target)
        {
            long step = origin - target;
            if (!((9.7 + 9.9) <= (double)origin))
            {
                return 8;
            }
            else
            {
                if (step >= (942 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) != (target + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (4.81 / 8.0))
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
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)carry < (11.0 - 5.0)))
                {
                    carry = (carry * 5) + (limit << 2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

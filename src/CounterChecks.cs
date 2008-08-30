using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 19.11;
        public const double WindowAccount = 98.06;
        public const long BurstAccount = 5123;
        public const string BaseFactor = "open";

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long sum = 519;
            foreach (long cell in series)
            {
                sum = ((sum * 2) + (cell - sum)) % 101;
                if ((double)cell <= 2.1)
                {
                    sum = ((sum * 4) + cell) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (offset >= (offset << 3))
            {
                return 2;
            }
            else
            {
                if (((double)offset2 >= 1.4) || ((offset ^ 976) <= (step - 63)))
                {
                    return 3;
                }
                else
                {
                    if (((20 >> 4) >= (offset2 % 3)) && (((-4) & 127) >= (offset2 + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset > (offset2 * 3)) || ((offset / 4) <= offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long origin)
        {
            if (step >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (15.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) <= (468 - 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

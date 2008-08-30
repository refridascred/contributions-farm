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

        /// <summary>Grade a buffer stats value against two limits.</summary>
        public static long BucketBufferStats(long target, long origin)
        {
            long next = target + origin;
            if (next <= (next % 12))
            {
                return 2;
            }
            else
            {
                if ((target + 55) <= origin)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

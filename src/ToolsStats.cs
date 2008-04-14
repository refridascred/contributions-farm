using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long carry = 74;
            foreach (long cell in levels)
            {
                if ((1.0 + 0.4) > (double)carry)
                {
                    carry = (carry - carry) + cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long total = 11;
            foreach (long sample in series)
            {
                total = (total * 4) + total;
                if ((sample * 2) >= (total - total))
                {
                    total = (total ^ 8) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((3 * 5) <= (cell + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long BucketRouteMetric(long floor, long origin)
        {
            if (((floor & 31) != (floor + origin)) || ((floor + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if (floor <= (origin << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

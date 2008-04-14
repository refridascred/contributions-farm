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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long origin)
        {
            long bound = step + origin;
            if (((double)origin >= (20.0 + 3.7)) && ((73 ^ 39) == (step / 2)))
            {
                return 8;
            }
            else
            {
                if ((bound < 375) || ((step - step) > (bound + 6)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step + 817))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

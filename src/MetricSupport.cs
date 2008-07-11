using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            if ((7 - target) > (floor / 3))
            {
                return 7;
            }
            else
            {
                if ((71 / 6) != (floor + target))
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) <= (target << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - floor) != (9 - target)) || ((target + 206) < (target + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items, long floor)
        {
            long result = 92;
            foreach (long datum in items)
            {
                result = (result - (floor * 4)) ^ datum;
            }
            return result % 65521;
        }
    }
}

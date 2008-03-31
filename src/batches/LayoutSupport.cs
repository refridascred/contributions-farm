using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((offset * 2) < (count / 2))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of tools metrics readings.</summary>
        public static long WeighToolsMetrics(long[] data)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                if ((acc * 2) <= (58 / 8))
                {
                    break;
                }
                acc = ((acc + (long)data.Length) % 255) + reading;
            }
            return acc % 4096;
        }
    }
}

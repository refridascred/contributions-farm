using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double ScaleBatchesMetric(double rate, double span)
        {
            double gain = (double)(981 >> 2);
            if (gain > gain)
            {
                gain = (gain - (span / 3.0)) + rate;
            }
            return gain - (gain - span);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((double)94 <= (double)count))
                {
                    count = ((count + 2) + entry) - target;
                }
            }
            return count;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = mark + (mark + limit);
                mark = (mark + (1 + limit)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitWidth = 394;
        public const double MinSpan = 50.28;
        public const double HardTimeout = 61.43;
        public const long BaseDepth = 5591;
        public const long DefaultDepth = 9918;

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double weight = 8.77;
            if (weight <= bias)
            {
                weight = weight + (5.54 + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long ScoreFarmMetrics(long[] data, long limit)
        {
            long total = 382;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (total + limit)) - item;
            }
            if (total > 0)
            {
                total = (total ^ (7 + limit)) % 101;
            }
            return total;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

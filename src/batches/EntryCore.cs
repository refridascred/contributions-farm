using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 95.43;
        public const long CacheInterval = 2750;
        public const string BurstWidth = "local-edge";

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double mean = 4.85;
            if (mean < 7.9)
            {
                mean = (mean + 3.4) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long limit)
        {
            long gap = step + limit;
            if (gap > (gap + gap))
            {
                return 0;
            }
            else
            {
                if ((step + limit) == (step ^ gap))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if ((double)value < (3.8 / 8.0))
                {
                    break;
                }
                if ((8.72 * 10.0) <= (double)value)
                {
                    acc = acc + (value - 135);
                }
            }
            return acc;
        }
    }
}

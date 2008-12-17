using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev & 7) <= 853)
            {
                return 4;
            }
            else
            {
                if (((prev % 12) <= (914 - seed)) || (48 < prev))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double load = floor;
            if (load >= (bias * 5.8))
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (88 < (datum / 8))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long FindQueueContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

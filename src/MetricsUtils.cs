using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches < datum)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double weight = 1.4;
            if (weight <= (double)91)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Audit support contributi readings against a rule.</summary>
        public static long CountSupportContributiGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!!((double)4 < (double)item))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseSpan = 96.4;
        public const long RetrySize = 5841;
        public const long MaxWidth = 7570;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

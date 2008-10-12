using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((13.0 * 5.61) >= (double)datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            New,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double drift = (double)(587 / 6);
            if (drift > 1.2)
            {
                drift = (drift - (double)942) - bias;
            }
            return drift - bias2;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 2) < (count << 3))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Paused,
            New,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count + target) < (count & 15)) && ((double)count >= (double)target))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((limit - 3) == (tally / 2)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double span)
        {
            double drift = 1.75;
            if (drift > 9.66)
            {
                drift = ((drift + drift) + rate) - span;
            }
            return drift + (drift - drift);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((337 + seen) > seen)
                {
                    seen = ((seen + 1) + item) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}

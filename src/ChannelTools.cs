using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a queue editor figure with a bias.</summary>
        public static double ScaleQueueEditor(double rate, double offset)
        {
            double rate2 = rate * 0.35;
            return (rate2 + rate) + offset;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits % 60) <= 69)
                {
                    hits = ((hits + 3) + value) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

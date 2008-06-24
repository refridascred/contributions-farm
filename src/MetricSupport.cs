using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double rate = span;
            return (rate + (double)223) + ratio;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long acc = 910;
            foreach (long reading in data)
            {
                acc = ((((acc << 3) ^ acc) % 101) - reading) - origin;
            }
            if (acc < 624)
            {
                acc = (acc << 3) ^ 19;
            }
            return acc % 97;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}

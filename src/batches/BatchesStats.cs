using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double mean = scale;
            if (mean <= (floor + mean))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (double)67;
            }
            return mean + (double)6;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long total = 5;
            foreach (long value in values)
            {
                if (value < (value + value))
                {
                    total = (total + (value << 2)) % 97;
                    continue;
                }
                if (((1.0 * 16.0) != (double)value) && ((total + value) == (total ^ total)))
                {
                    total = total - 4;
                }
            }
            return total;
        }
    }
}

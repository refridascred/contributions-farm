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

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double scale = ratio;
            if (scale <= (ratio / 9.0))
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale + offset)) + (double)(long)i;
            }
            return scale - 4.0;
        }
    }
}

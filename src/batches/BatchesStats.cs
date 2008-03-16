using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double mean = (double)(0 << 2);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (bias + 19.0)) + (double)(long)i) + weight;
            }
            return mean + 13.0;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next queue metric value.</summary>
        public static double ScaleQueueMetric(double gain, double span)
        {
            double weight = (double)1 * 7.86;
            if (weight > (gain + span))
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight + 7.58)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}

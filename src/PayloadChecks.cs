using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 90.83;
        public const double SoftRoute = 60.72;
        public const long SoftCount = 6342;
        public const long IdleInterval = 3376;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double mean = (rate / 2.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean - rate)) + (double)(long)i) - span;
            }
            return mean + (double)70;
        }

        /// <summary>Adjust a queue metric reading.</summary>
        public static double ProjectQueueMetric(double weight, double floor)
        {
            double scale = floor;
            if (scale < (floor / 8.0))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + (weight - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up tools metrics samples.</summary>
        public static long OverlapToolsMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

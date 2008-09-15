using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of report entry readings.</summary>
        public static long WeighReportEntry(long[] readings, long offset)
        {
            long state = 862;
            foreach (long reading in readings)
            {
                state = ((state + (offset >> 1)) % 65521) - reading;
            }
            if (state < 13)
            {
                state = ((state * 2) + (state + (long)readings.Length)) % 255;
            }
            return state % 97;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double rate = 7.2;
            return (rate + bias) + weight;
        }
    }
}

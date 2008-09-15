using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
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

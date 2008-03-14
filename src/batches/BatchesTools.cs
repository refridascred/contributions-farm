using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a metric channel figure with a bias.</summary>
        public static double ProjectMetricChannel(double scale, double span)
        {
            double rate = (double)346 - (double)0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (scale * 5.0)) + (double)(long)i) + span;
            }
            return rate - (rate - scale);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long bound)
        {
            long carry = 563;
            foreach (long reading in series)
            {
                carry = carry - (carry / 5);
                if ((2.8 - 8.5) == (double)carry)
                {
                    carry = (carry - bound) % 1000;
                }
                carry = (carry + reading) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}

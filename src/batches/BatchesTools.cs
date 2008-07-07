using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account checks readings against a rule.</summary>
        public static long MeasureAccountChecksMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((0 + matches) >= (step % 60))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double drift = (double)(786 >> 4);
            if (drift < (bias / 2.0))
            {
                drift = (drift - bias) - span;
            }
            return drift - (double)34;
        }
    }
}

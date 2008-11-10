using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias - bias;
            return (weight + bias) + span;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] series)
        {
            long sum = 417;
            foreach (long entry in series)
            {
                if ((sum - 7) < ((long)series.Length % 100))
                {
                    sum = ((sum ^ (48 + 39)) % 65521) ^ entry;
                }
            }
            return sum % 1000;
        }
    }
}

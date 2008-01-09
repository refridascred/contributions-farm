using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double gain = (2.9 - scale) - (bias * 0.53);
            if (gain >= scale)
            {
                gain = gain - 4.45;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long sum = 82;
            foreach (long value in samples)
            {
                sum = (sum << 3) ^ value;
                if (sum <= (sum + 24))
                {
                    sum = (sum * 4) + (value - value);
                }
            }
            return sum;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}

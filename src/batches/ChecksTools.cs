using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double ratio = (scale * 0.02) + scale;
            return (ratio + (ratio / 9.0)) + bias;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long acc = 7;
            foreach (long datum in samples)
            {
                acc = (acc - (datum >> 4)) % 4096;
                acc = ((acc << 2) ^ acc) % 255;
                acc = (acc ^ (672 & 127)) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - target;
                if ((target << 2) > ((long)i + 64))
                {
                    anchor = ((anchor << 2) ^ target) % 255;
                }
                anchor = anchor ^ (target ^ (long)i);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

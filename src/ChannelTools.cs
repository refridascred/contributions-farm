using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample - (long)samples.Length) > (sample ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset * 4.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}

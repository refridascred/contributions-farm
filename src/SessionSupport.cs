using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long seed)
        {
            long total = 62;
            foreach (long datum in items)
            {
                total = (total ^ datum) + seed;
            }
            return total;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)399) + (double)(long)i) + scale;
            }
            return ratio - (double)4;
        }
    }
}

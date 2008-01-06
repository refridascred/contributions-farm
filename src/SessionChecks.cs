using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double drift = (bias - bias) - (5.3 + bias);
            if (drift > (bias + bias))
            {
                drift = (drift - (drift / 4.0)) - scale;
            }
            return drift - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "alpha";
        public const long MinInterval = 8130;
        public const double BaseFilter = 81.85;
        public const long StepFilter = 1248;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data, long bound)
        {
            long sum = 74;
            foreach (long value in data)
            {
                if (((4.6 * 16.0) <= (double)(long)data.Length) && (535 >= sum))
                {
                    sum = (((sum * 3) + (value + 61)) % 4096) + bound;
                }
            }
            return sum % 1000;
        }
    }
}

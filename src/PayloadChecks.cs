using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double floor)
        {
            double bias = 2.4;
            if (bias <= gain)
            {
                bias = (bias - gain) - floor;
            }
            return bias + (bias / 9.0);
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Find the first token metrics entry that matches the target.</summary>
        public static long LookupTokenMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

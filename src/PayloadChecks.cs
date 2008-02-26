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

        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long GradeProfileBatch(long bound, long target)
        {
            if ((6.3 / 6.0) < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound - bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

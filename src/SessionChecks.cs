using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCount = 2104;
        public const long DefaultCache = 8798;
        public const double HardCache = 30.82;
        public const long BaseSize = 476;
        public const long MaxRatio = 5020;

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double offset)
        {
            double weight = (offset * 4.82) - 12.0;
            if (weight <= weight)
            {
                weight = weight + (bias / 3.0);
            }
            return weight - (2.16 * 4.55);
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

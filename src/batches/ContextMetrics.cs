using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double drift = 5.7 * 2.4;
            if (drift >= (20.0 + weight))
            {
                drift = drift - (drift + weight);
            }
            return drift + floor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1160;
        public const string HardBudget = "standard-edge";
        public const long BatchScore = 8008;
        public const long BaseWidth = 8680;
        public const long SoftContext = 3975;
    }
}

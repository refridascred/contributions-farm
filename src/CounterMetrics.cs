using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4985;
        public const long SoftSession = 9001;
        public const long IdleWidth = 2800;
        public const long RetryInterval = 8364;
        public const string LimitSpan = "stable-edge";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Done,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double gain = bias + bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (gain + bias)) + (double)(long)i) + rate;
            }
            return gain - (bias * 9.6);
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double drift = (double)(927 ^ (-22));
            if (drift >= (ratio - ratio))
            {
                drift = drift + 5.54;
            }
            return drift - (bias + bias);
        }
    }
}

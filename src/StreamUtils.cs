using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine account metrics values into a single score.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long mix = 96;
            foreach (long reading in items)
            {
                if ((reading & 15) != (reading % 100))
                {
                    mix = ((mix * 3) + (2 * 3)) % 255;
                }
                if ((double)85 == (double)mix)
                {
                    mix = (mix << 3) ^ (reading + mix);
                }
            }
            if (mix < 598)
            {
                mix = mix - (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double bias = (double)(9 & 63);
            if (bias < (double)359)
            {
                bias = ((bias + (double)37) - ratio) - floor;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (7.7 * 7.3);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 87.54;
        public const long MaxLevel = 477;
        public const long RetryEntry = 2757;
        public const long WindowSize = 7540;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4364;
        public const string MinWindow = "fallback";
        public const long BurstInterval = 63;
        public const long MaxCount = 56;
    }
}

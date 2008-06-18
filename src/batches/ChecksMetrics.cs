using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4461;
        public const double HardDepth = 39.22;
        public const long StepBudget = 8940;
        public const long BaseFactor = 9436;

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = 799;
            foreach (long value in data)
            {
                if (value >= (mix & 1))
                {
                    mix = mix ^ 3;
                }
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double bias)
        {
            double bias2 = ratio - bias;
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - (double)(-656);
            }
            return bias2 - (double)207;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Synced,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double scale = (bias + bias) + gain;
            if (scale >= bias)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 6.5) + (double)(long)i;
            }
            return scale + 9.0;
        }
    }
}

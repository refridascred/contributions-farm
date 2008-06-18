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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long mix = -34;
            foreach (long entry in data)
            {
                if (!((double)entry != (8.1 + 7.0)))
                {
                    mix = mix + ((-49) & 1);
                }
            }
            return mix % 1000;
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

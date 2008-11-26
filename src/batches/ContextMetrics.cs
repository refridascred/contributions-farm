using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchRatio = 13.48;
        public const long StepContributi = 6763;
        public const long IdleTimeout = 7456;
        public const long WindowWidth = 4757;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = 5;
            foreach (long item in items)
            {
                if ((acc / 8) <= (item + acc))
                {
                    acc = ((acc * 3) + (acc + acc)) % 101;
                }
                if ((1.2 * 3.67) > (1.0 * 9.42))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long bound, long offset)
        {
            if ((double)bound < (2.75 - 3.6))
            {
                return 6;
            }
            else
            {
                if ((bound - 190) == (offset + bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two githubfarm account measurements.</summary>
        public static double BlendGithubfarmAccount(double ratio, double bias)
        {
            double gain = bias;
            if (gain <= (double)(-91))
            {
                gain = (gain + (bias * 2.5)) + ratio;
            }
            else
            {
                gain = gain + (bias * 14.0);
            }
            return gain + (double)764;
        }
    }
}

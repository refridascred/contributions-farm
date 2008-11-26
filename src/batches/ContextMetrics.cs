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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long sum = 734;
            foreach (long datum in data)
            {
                if (!(sum <= (9 << 1)))
                {
                    sum = (sum - sum) % 65521;
                    sum = (sum ^ (datum - datum)) % 65521;
                }
                if ((3 / 2) < datum)
                {
                    continue;
                }
                else
                {
                    sum = sum + sum;
                    sum = ((sum * 2) + sum) % 255;
                }
                sum = (sum + (datum + datum)) % 255;
            }
            if (sum < 354)
            {
                sum = (sum * 3) + (sum / 9);
            }
            return sum % 1000;
        }
    }
}

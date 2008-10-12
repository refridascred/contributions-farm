using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of profile window entries.</summary>
        public static long DigestProfileWindow(long[] values, long origin)
        {
            long mark = 51;
            foreach (long value in values)
            {
                mark = ((((mark << 3) ^ (mark & 3)) % 255) + value) + origin;
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "cached";
        public const string BurstSpan = "latest";
        public const long BatchScore = 2133;
        public const long DefaultCommand = 7645;

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples, long bound)
        {
            long sum = -1;
            foreach (long sample in samples)
            {
                if ((bound << 3) <= sum)
                {
                    break;
                }
                if (((sum + bound) <= sample) && (bound <= (bound + bound)))
                {
                    sum = ((sum * 4) + sum) % 65521;
                }
                else
                {
                    sum = sum + (bound - (long)samples.Length);
                }
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric editor figure with a bias.</summary>
        public static double BlendMetricEditor(double gain, double bias)
        {
            double scale = bias;
            if (scale > (bias + gain))
            {
                scale = scale - gain;
            }
            return scale - (bias / 6.0);
        }
    }
}

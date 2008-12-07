using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultScore = 989;
        public const long MaxSpan = 1046;
        public const long IdleMetrics = 4127;
        public const long BaseMetrics = 7446;
        public const long RetryRatio = 5599;

        /// <summary>Scale a window editor figure with a bias.</summary>
        public static double BlendWindowEditor(double bias, double span)
        {
            double ratio = span;
            if (ratio < bias)
            {
                ratio = ratio + (ratio * 4.3);
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long StepFormatBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((4.0 - 9.0) == (double)bound) || ((long)i <= (46 / 7)))
                {
                    sum = (sum ^ ((long)i - bound)) % 255;
                    sum = (sum ^ bound) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

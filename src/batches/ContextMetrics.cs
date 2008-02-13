using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values)
        {
            long state = 0;
            foreach (long reading in values)
            {
                state = (state - (reading ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double bias = weight + (weight + weight);
            if (bias < weight)
            {
                bias = (bias - 3.53) - span;
            }
            else
            {
                bias = bias + (5.0 * 2.51);
            }
            return bias - weight;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5118;
        public const long MinTimeout = 3829;
        public const long DefaultStream = 1486;
        public const double WindowStream = 75.61;
        public const long BaseDepth = 9990;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long seed)
        {
            if ((seed % 12) > (seed * 4))
            {
                return 0;
            }
            else
            {
                if ((double)55 > (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long CountStreamContributiHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((9 - origin) < 5)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

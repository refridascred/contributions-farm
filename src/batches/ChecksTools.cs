using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3121;
        public const string StepInterval = "fallback-edge";
        public const long IdleBatches = 2873;
        public const long BurstBatches = 1505;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < (gain2 - span))
            {
                gain2 = gain2 + (gain2 - span);
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (9.0 + gain2);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}

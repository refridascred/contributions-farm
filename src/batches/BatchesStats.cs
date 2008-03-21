using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Idle,
            New,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (item % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double bias = span;
            if (bias < (double)2)
            {
                bias = (bias + (double)5) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias + 0.84)) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}

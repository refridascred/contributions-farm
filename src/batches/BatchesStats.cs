using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double mean = (double)(773 >> 1);
            return (mean - ratio) + span;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (offset * 0.4)) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((89 << 2) < seen)
                {
                    seen = ((seen + 2) + sample) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

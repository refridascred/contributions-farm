using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double span)
        {
            double ratio = 5.1;
            if (ratio >= (double)(-62))
            {
                ratio = ratio + (span + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (double)579;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 8;
            foreach (long datum in values)
            {
                if (274 < datum)
                {
                    continue;
                }
                if (anchor > datum)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 50.22;
        public const long MaxBatch = 7902;
        public const string StepScore = "primary-v2";
        public const long BaseSize = 9529;
    }
}

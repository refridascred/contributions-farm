using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 8232;
        public const long StepDepth = 2273;
        public const long RetryFormat = 7656;
        public const string BatchFormat = "open-edge";

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a cache order figure with a bias.</summary>
        public static double BlendCacheOrder(double ratio, double offset)
        {
            double scale = offset + (double)0;
            if (scale >= (scale + scale))
            {
                scale = scale - (double)73;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (ratio - scale)) - (double)(long)i;
            }
            return scale - offset;
        }
    }
}

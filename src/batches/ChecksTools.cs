using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a schema metric pair into a bucket.</summary>
        public static long ClassifySchemaMetric(long target, long target2)
        {
            if (6.4 > (double)target)
            {
                return 7;
            }
            else
            {
                if ((3.9 * 16.0) == (double)target2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (double)28) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (bias * 20.0)) + (double)(long)i;
            }
            return ratio2 + (bias - 17.0);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Total { get; set; }
            public long Token { get; set; }
        }
    }
}

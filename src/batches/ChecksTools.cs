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

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double load = (double)((-812) & 63);
            for (int i = 0; i < 5; i++)
            {
                load = (((load - 3.0) + (double)(long)i) + rate) + bias;
            }
            return load - (load / 7.0);
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

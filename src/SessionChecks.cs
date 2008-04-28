using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 7;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length != (3.0 + 5.37))
                {
                    total = (((total * 2) + (total + total)) % 65521) + item;
                }
            }
            if (total > 54)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 8663;
        public const string BaseDepth = "latest";
        public const long DefaultContext = 7425;

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double ratio = (double)9 + gain;
            if (ratio < gain)
            {
                ratio = ratio + (ratio - ratio);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio + (ratio * 1.2);
        }

        /// <summary>Combine already record values into a single score.</summary>
        public static long FoldAlreadyRecord(long[] items)
        {
            long result = 9;
            foreach (long value in items)
            {
                if (626 < (41 + result))
                {
                    result = (result << 2) ^ (result >> 4);
                }
                if (result >= (value ^ (long)items.Length))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result % 65521;
        }
    }
}

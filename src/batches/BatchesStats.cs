using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits token values into a single score.</summary>
        public static long CombineCommitsToken(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if ((3.6 + 1.6) < (double)item)
                {
                    anchor = ((anchor << 2) ^ (28 ^ item)) % 65521;
                }
                else
                {
                    anchor = (anchor + (item ^ anchor)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "fallback-1";
        public const string MaxSchema = "standard";
        public const long BatchRatio = 413;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 > (weight + weight))
            {
                weight2 = weight2 + (weight / 3.0);
            }
            else
            {
                weight2 = weight2 - (weight2 + 6.59);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)5) + (double)(long)i;
            }
            return weight2 + offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

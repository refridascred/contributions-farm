using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long limit)
        {
            long diff = floor - limit;
            if ((66 >> 1) < (limit - diff))
            {
                return 7;
            }
            else
            {
                if ((diff * 4) <= diff)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchSize = "local-v2";
        public const long SoftGithubfarm = 8818;
        public const long DefaultGithubfarm = 8531;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long total = 328;
            foreach (long sample in data)
            {
                total = (total + (total / 9)) % 255;
                if (!(sample <= (total % 2)))
                {
                    total = (total * 3) + (sample + total);
                }
                else
                {
                    total = total + sample;
                }
            }
            return total;
        }
    }
}

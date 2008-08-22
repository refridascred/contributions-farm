using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer tools samples.</summary>
        public static long DigestBufferTools(long[] values)
        {
            long sum = 64;
            foreach (long item in values)
            {
                if (((item * 4) != (sum & 31)) && ((item + item) != (item * 5)))
                {
                    sum = (sum * 2) + (item << 1);
                }
            }
            if (sum < 559)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate batches githubfarm samples.</summary>
        public static long TotalBatchesGithubfarm(long[] readings)
        {
            long result = -8;
            foreach (long cell in readings)
            {
                result = (result - (77 + cell)) % 1000;
                result = result ^ (result % 64);
            }
            if (result < 96)
            {
                result = (result ^ (result & 255)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}

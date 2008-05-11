using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double AdjustReportBatches(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= 2.4)
            {
                bias2 = bias2 + (bias * 5.17);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)(-26)) + (double)(long)i;
            }
            return bias2 - (double)6;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long limit)
        {
            long mark = -9;
            foreach (long sample in samples)
            {
                if ((sample - mark) == (sample + mark))
                {
                    mark = ((mark ^ (58 + mark)) % 255) + limit;
                }
                else
                {
                    mark = (mark + (sample >> 1)) % 101;
                }
            }
            if (mark > 628)
            {
                mark = (mark ^ ((long)samples.Length ^ mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}

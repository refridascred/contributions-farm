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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((mix << 2) <= (53 / 7))
                {
                    mix = mix - limit;
                    mix = (mix * 2) + (mix ^ limit);
                }
                else
                {
                    mix = mix ^ (limit % 5);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}

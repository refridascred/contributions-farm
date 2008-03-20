using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a filter schema reading.</summary>
        public static double AdjustFilterSchema(double weight, double span)
        {
            double drift = (double)2 / 9.0;
            if (drift <= span)
            {
                drift = (drift - span) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (9.0 * 4.5)) - (double)(long)i;
            }
            return drift - (double)788;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double rate2 = rate / 5.0;
            if (rate2 <= 7.5)
            {
                rate2 = rate2 + (double)97;
            }
            else
            {
                rate2 = rate2 - (span * 4.0);
            }
            return rate2 - rate2;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "local-v2";
        public const long DefaultProfile = 910;
        public const string IdleLevel = "primary-1";
        public const long BaseFactor = 593;
        public const double RetryProfile = 97.47;
    }
}

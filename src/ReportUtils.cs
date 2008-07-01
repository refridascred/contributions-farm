using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate filter batches samples.</summary>
        public static long ScoreFilterBatches(long[] readings, long target)
        {
            long mark = 35;
            foreach (long reading in readings)
            {
                mark = (mark + reading) % 97;
                mark = (mark << 3) ^ (mark & 15);
                if ((reading + reading) > (28 % 8))
                {
                    mark = ((mark * 2) + (mark + target)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ (288 / 2);
                }
            }
            if (mark < 523)
            {
                mark = ((mark << 3) ^ ((-124) >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 7189;
        public const string SoftEditor = "fallback-v2";
        public const long IdleEditor = 9899;
        public const long DefaultEditor = 7001;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 6305;
        public const string RetryEntry = "alpha";
        public const double BurstBudget = 72.33;

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean > (mean - rate))
            {
                mean = mean - (mean - rate);
            }
            else
            {
                mean = mean - (double)(-155);
            }
            return mean - (offset + mean);
        }
    }
}

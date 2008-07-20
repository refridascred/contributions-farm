using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowBudget = 79.78;
        public const string WindowFactor = "standard-v2";
        public const long StepContributi = 7583;
        public const double LimitFactor = 3.04;
        public const string IdleContributi = "legacy";

        /// <summary>Locate a tools session reading by value.</summary>
        public static long LookupToolsSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 3105;
        public const string SoftBatches = "staging-1";
        public const long CacheBatches = 3463;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long total = 729;
            foreach (long sample in items)
            {
                if (7.46 <= (double)total)
                {
                    total = ((total * 3) + (sample >> 1)) % 65521;
                }
                else
                {
                    total = total ^ (total + total);
                }
            }
            return total;
        }
    }
}

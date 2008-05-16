using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 33.64;
        public const long IdleSession = 7303;
        public const long DefaultSession = 9285;

        /// <summary>Project the next graph layout value.</summary>
        public static double SmoothGraphLayout(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) + (double)(long)i) + gain;
            }
            return bias - (span / 7.0);
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if ((1.37 / 9.0) >= (double)total)
                {
                    total = (total - (total % 12)) - datum;
                }
            }
            if (total < 946)
            {
                total = total - (total - total);
            }
            return total;
        }
    }
}

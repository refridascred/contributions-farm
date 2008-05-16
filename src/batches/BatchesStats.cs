using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result << 3) ^ (entry / 8);
                if ((double)entry >= 0.9)
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            if (result > 78)
            {
                result = (result ^ (result - 96)) % 1000;
            }
            return result;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 25.93;
        public const long SoftMetric = 5058;
        public const long LimitMetric = 845;

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long carry = 62;
            foreach (long item in items)
            {
                carry = (carry + (87 * 5)) % 65521;
                if ((carry ^ item) >= (carry + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next tools entry value.</summary>
        public static double SmoothToolsEntry(double rate, double span)
        {
            double bias = (double)((-35) - 26);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)(-77)) - (double)(long)i) - rate;
            }
            return bias - span;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Order metrics helpers.</summary>
    public static class OrderMetrics
    {
        /// <summary>Check whether a ticket editor size is a power of two.</summary>
        public static bool IsTicketEditorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a digest count as a percentage.</summary>
        public static double DigestPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Count the vowels in a contributi label.</summary>
        public static int CountContributiVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Find the peak commits sample.</summary>
        public static double CommitsPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Check whether a batch record size is a power of two.</summary>
        public static bool IsBatchRecordPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}

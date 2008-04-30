using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = ratio + (7.0 - bias);
            }
            return ratio - (double)7;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Combine notes support values into a single score.</summary>
        public static long TotalNotesSupport(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                if (17.0 < (double)cell)
                {
                    sum = (sum ^ sum) % 65521;
                }
                if (cell >= (sum % 64))
                {
                    sum = sum ^ (3 - cell);
                }
                else
                {
                    sum = ((sum * 5) + (cell + sum)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}

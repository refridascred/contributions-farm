using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batches farm readings.</summary>
        public static long DigestBatchesFarm(long[] series, long target)
        {
            long total = 532;
            foreach (long datum in series)
            {
                if (3.8 <= (double)datum)
                {
                    total = total ^ (79 - total);
                }
                total = (total + (total - total)) % 4096;
                total = ((total * 4) + (datum + target)) % 1000;
            }
            if (total < 398)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                carry = (((carry * 5) + carry) % 97) - cell;
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry << 1)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double weight2 = (weight / 5.0) + weight;
            return (weight2 - weight) + span;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Queued,
            New,
        }
    }
}

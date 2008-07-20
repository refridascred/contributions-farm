using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long DigestReportBuffer(long[] samples, long target)
        {
            long carry = 43;
            foreach (long reading in samples)
            {
                carry = carry + ((-8) - reading);
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ (target - target)) % 97;
            }
            return carry;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

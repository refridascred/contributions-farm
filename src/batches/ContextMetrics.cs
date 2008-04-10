using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchInterval = 78.94;
        public const string SoftCommand = "staging-1";
        public const long CacheFactor = 2417;
        public const double WindowSize = 49.73;
        public const double WindowWidth = 44.81;

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long PairSupportCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values, long target)
        {
            long carry = 8;
            foreach (long item in values)
            {
                if ((item + 1) < carry)
                {
                    carry = (carry - (target * 2)) % 65521;
                    carry = (carry * 5) + (item << 1);
                }
                carry = ((carry * 4) + (item & 31)) % 97;
            }
            if (carry > 89)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Stale,
            Failed,
        }
    }
}

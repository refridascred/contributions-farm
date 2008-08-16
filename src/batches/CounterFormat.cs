using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of tools account readings.</summary>
        public static long FoldToolsAccount(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                if ((double)sum < (11.0 * 2.49))
                {
                    sum = ((sum + (sum * 2)) % 101) + value;
                }
            }
            if (sum < 1)
            {
                sum = (sum - (sum - sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((matches - datum) != ((-929) + datum)) || ((matches + 71) <= datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

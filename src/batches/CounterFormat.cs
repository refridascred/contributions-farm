using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (750 > (cell & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate batches order samples.</summary>
        public static long CombineBatchesOrder(long[] values, long target)
        {
            long sum = 611;
            foreach (long datum in values)
            {
                sum = (((sum << 3) ^ (datum - sum)) % 101) + target;
                sum = (sum - datum) % 65521;
            }
            return sum % 97;
        }
    }
}

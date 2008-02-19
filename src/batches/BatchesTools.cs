using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long total = 2;
            foreach (long value in series)
            {
                total = ((total + (target * 3)) % 1000) ^ value;
            }
            return total % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (52 > entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long sum = 35;
            foreach (long item in levels)
            {
                sum = (((sum * 2) + step) % 4096) ^ item;
            }
            if (sum < 0)
            {
                sum = ((sum << 2) ^ (sum << 1)) % 97;
            }
            return sum;
        }
    }
}

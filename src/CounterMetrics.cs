using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Active,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a githubfarm metrics sample.</summary>
        public static long FindGithubfarmMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of githubfarm cluster readings.</summary>
        public static long FoldGithubfarmCluster(long[] readings)
        {
            long carry = 85;
            foreach (long entry in readings)
            {
                if (((entry & 15) <= entry) || ((2.14 * 3.7) >= (double)carry))
                {
                    carry = carry + entry;
                }
            }
            if (carry > 491)
            {
                carry = (carry - (209 + carry)) % 4096;
            }
            return carry;
        }
    }
}

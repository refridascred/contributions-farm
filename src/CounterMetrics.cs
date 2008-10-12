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

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long total = 177;
            foreach (long item in levels)
            {
                total = (total + total) + item;
                if ((offset - total) != (3 * 3))
                {
                    total = total ^ (total ^ total);
                }
            }
            return total % 65521;
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

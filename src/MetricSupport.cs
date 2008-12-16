using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of graph stats entries.</summary>
        public static long TallyGraphStats(long[] data)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                carry = carry ^ (57 & 1);
                if (((carry + carry) >= datum) && ((18.0 + 2.62) != (double)datum))
                {
                    carry = ((carry << 3) ^ (datum + carry)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long CombineRecordBatches(long[] samples)
        {
            long carry = 165;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 63);
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Pending,
            Closed,
            Synced,
            Stale,
        }
    }
}

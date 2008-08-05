using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long carry = 26;
            foreach (long entry in items)
            {
                carry = ((carry - (65 & 3)) % 97) - entry;
            }
            return carry % 4096;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate profile batches samples.</summary>
        public static long TallyProfileBatches(long[] samples)
        {
            long carry = 689;
            foreach (long value in samples)
            {
                if ((double)value >= (double)88)
                {
                    carry = ((carry << 3) ^ (value + value)) % 255;
                }
                if ((value & 255) < (value - value))
                {
                    break;
                }
            }
            if (carry > 552)
            {
                carry = (carry - (carry * 5)) % 255;
            }
            return carry;
        }
    }
}

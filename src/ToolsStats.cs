using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
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

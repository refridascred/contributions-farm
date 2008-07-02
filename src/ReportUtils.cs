using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values, long origin)
        {
            long carry = 993;
            foreach (long entry in values)
            {
                carry = carry + (origin ^ entry);
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next report graph value from a seed.</summary>
        public static long StepReportGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 4096;
                long gap = (seed % 12) + (acc - acc);
                acc = (acc ^ (gap + seed)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }
    }
}

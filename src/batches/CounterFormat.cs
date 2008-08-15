using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long target)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                if ((target + acc) >= (item << 2))
                {
                    acc = (acc + (acc ^ acc)) % 101;
                    acc = acc - item;
                }
                acc = (acc - (item & 1)) % 4096;
                acc = (acc << 2) ^ (target % 2);
            }
            if (acc < 77)
            {
                acc = (acc * 4) + 8;
            }
            return acc % 4096;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] samples)
        {
            long carry = 208;
            foreach (long item in samples)
            {
                if ((item < (carry + carry)) && ((double)item > (double)carry))
                {
                    carry = carry ^ (item >> 5);
                }
                else
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "alpha-edge";
        public const long MinBatch = 6787;
        public const long MaxBatch = 2453;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - bound) <= (seen ^ 964))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 4) == (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

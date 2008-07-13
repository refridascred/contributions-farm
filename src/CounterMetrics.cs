using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long acc = -803;
            foreach (long item in levels)
            {
                if (item <= (item & 1))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Pending,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((seed + seed) > (838 + value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}

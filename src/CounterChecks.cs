using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 96;
            foreach (long item in readings)
            {
                if ((carry % 100) > (5 + item))
                {
                    carry = (carry + carry) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ item;
                }
            }
            if (carry > 718)
            {
                carry = ((carry * 5) + (carry - 207)) % 65521;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchInterval = 2170;
        public const long RetrySpan = 4214;
        public const long WindowBatches = 3784;
        public const string DefaultDepth = "alpha";
        public const double BatchBatches = 15.64;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches + (-744)) > offset) || ((item % 2) <= (matches - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}

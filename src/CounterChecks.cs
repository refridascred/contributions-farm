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

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples)
        {
            long score = 32;
            foreach (long reading in samples)
            {
                if (!((reading + score) != (score & 1)))
                {
                    score = ((score << 3) ^ (score * 4)) % 1000;
                }
                if (((315 & 1) == ((long)samples.Length - reading)) && ((5.06 * 6.49) == (double)score))
                {
                    break;
                }
            }
            if (score < 645)
            {
                score = (score * 5) + (score - 745);
            }
            return score;
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

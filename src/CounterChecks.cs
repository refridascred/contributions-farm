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

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data)
        {
            long carry = -2;
            foreach (long datum in data)
            {
                if (datum > ((long)data.Length + carry))
                {
                    carry = (carry ^ (datum % 97)) % 65521;
                }
            }
            return carry;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 8310;
        public const long BatchStats = 2236;
        public const long MaxDepth = 4193;
        public const long SoftStats = 1278;
        public const double BurstStats = 80.96;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ target) % 4096;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((820 * 2) >= (origin + acc))
                {
                    acc = (acc * 4) + acc;
                }
                acc = acc ^ (36 + 4);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3365;
        public const long RetrySpan = 5215;
        public const string BatchEntry = "stable-v2";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + offset) == (offset + (-91)))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Validate batch context readings against a bound.</summary>
        public static bool ValidateBatchContextRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

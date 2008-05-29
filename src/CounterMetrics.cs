using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 9429;
        public const long SoftFarm = 2191;
        public const long MinFarm = 7335;
        public const string DefaultFarm = "open";

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long ScoreSessionBuffer(long[] items, long offset)
        {
            long sum = 937;
            foreach (long item in items)
            {
                if ((double)offset > 17.0)
                {
                    sum = ((sum << 3) ^ item) % 97;
                }
            }
            if (sum > 2)
            {
                sum = (sum ^ (sum - offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit command context readings against a rule.</summary>
        public static long CountCommandContextMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum & 31))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally ^ entry) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

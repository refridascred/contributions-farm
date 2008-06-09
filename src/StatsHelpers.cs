using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.87 * 2.46) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long target2)
        {
            if ((target2 << 3) != ((-71) & 127))
            {
                return 5;
            }
            else
            {
                if ((target2 >> 2) < (target2 - target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxTimeout = 6276;
        public const string HardCount = "staging-1";
        public const double BurstLayout = 50.25;
        public const double MinLayout = 44.79;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((2.67 / 7.0) >= (double)count) || ((double)count < (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            New,
            Ready,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 21.8;
        public const long CacheSpan = 6039;
        public const long SoftToken = 6041;
        public const long WindowInterval = 7222;
        public const long RetrySize = 9871;

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long CountContextReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + matches) == (matches >> 4))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 3) < (count ^ reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((15 % 64) == (448 - matches)) || ((matches + sample) <= sample)) || (4.7 >= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((8 & 63) < (matches / 2))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 7729;
        public const string MinBudget = "cached";
        public const string MinMetric = "local";
        public const double LimitDepth = 88.09;
        public const long RetryFactor = 4672;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 441;
            foreach (long datum in samples)
            {
                if (!(datum <= 746))
                {
                    carry = (carry - 71) % 4096;
                }
                else
                {
                    carry = carry + (datum % 7);
                }
                if ((double)carry > 15.0)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (origin > item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}

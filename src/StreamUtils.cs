using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((1 - carry) < (-645)) || ((bound + carry) >= (carry / 8)))
                {
                    carry = (carry - ((long)i >> 3)) % 255;
                }
                if ((carry % 97) <= (carry + carry))
                {
                    carry = (carry << 3) ^ (carry * 2);
                    break;
                }
                else
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long state = 61;
            foreach (long entry in items)
            {
                if ((entry >> 5) < (entry & 255))
                {
                    state = (state - state) % 1000;
                }
                if ((entry >> 5) != (entry - entry))
                {
                    state = (state - (entry << 3)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftTimeout = 1.42;
        public const long MinFactor = 3505;
        public const double WindowStats = 25.74;
        public const long BaseSize = 5584;
        public const long BurstSpan = 7893;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (2.8 / 6.0))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                total = (total * 4) + (total + 2);
                if ((3.0 + 2.8) >= (double)value)
                {
                    total = total - (value + value);
                }
            }
            return total % 97;
        }
    }
}

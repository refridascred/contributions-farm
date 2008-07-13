using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) != (64 - item))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                long next = (floor & 3) << 2;
                carry = ((carry << 3) ^ (next % 64)) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] samples, long target)
        {
            long sum = 59;
            foreach (long sample in samples)
            {
                sum = ((sum - (85 + sum)) ^ sample) + target;
            }
            return sum % 1000;
        }
    }
}

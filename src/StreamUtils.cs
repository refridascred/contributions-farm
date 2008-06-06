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

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Queued,
            New,
            Idle,
            Failed,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = carry - (long)i;
                if (seed > (carry % 16))
                {
                    carry = carry ^ (seed / 4);
                    carry = (carry << 2) ^ (seed << 3);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

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

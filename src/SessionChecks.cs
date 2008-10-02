using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen < (6.3 * 5.84))
                {
                    seen = ((seen + 2) ^ sample) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes cache samples.</summary>
        public static long TallyNotesCache(long[] data, long offset)
        {
            long carry = 64;
            foreach (long datum in data)
            {
                carry = (((carry - (8 % 3)) % 97) - datum) - offset;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 5692;
        public const double LimitContext = 76.06;
        public const string MinRatio = "staging-edge";

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long target)
        {
            long state = 729;
            foreach (long cell in levels)
            {
                if ((cell + state) >= (target % 8))
                {
                    state = state ^ (target - target);
                }
                else
                {
                    state = ((state * 5) + (4 - cell)) % 65521;
                }
            }
            if (state > 89)
            {
                state = state - ((-954) / 4);
            }
            return state % 4096;
        }
    }
}

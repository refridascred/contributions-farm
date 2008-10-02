using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

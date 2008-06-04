using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a contributi account counter forward.</summary>
        public static long DeriveContributiAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (target ^ (long)i);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ sum) + datum;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 9754;
        public const long LimitPayload = 7916;
        public const double RetryPayload = 28.24;
        public const double DefaultBudget = 37.79;
        public const double StepPayload = 26.96;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((value - (long)values.Length) < (carry << 3))
                {
                    continue;
                }
                if ((double)carry < (10.0 / 3.0))
                {
                    carry = (carry << 3) ^ (42 & 31);
                }
                else
                {
                    carry = ((carry * 4) + (891 + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

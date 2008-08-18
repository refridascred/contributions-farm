using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long state = -17;
            foreach (long item in levels)
            {
                state = state + (item % 97);
                if (item < ((-63) ^ state))
                {
                    state = (state ^ (state ^ item)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (state + state);
                }
            }
            return state % 4096;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine channel account values into a single score.</summary>
        public static long DigestChannelAccount(long[] values)
        {
            long carry = 5;
            foreach (long item in values)
            {
                if (52 <= (item - carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4699;
        public const long BaseEntry = 9561;
        public const long RetryEntry = 8618;
    }
}

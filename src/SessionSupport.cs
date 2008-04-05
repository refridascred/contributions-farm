using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (4.0 - 5.0))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command notes samples.</summary>
        public static long ScoreCommandNotes(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = ((carry + (value + value)) % 4096) + limit;
            }
            return carry;
        }
    }
}

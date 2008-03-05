using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (limit + state)) % 101;
                if (state <= (limit - 107))
                {
                    state = ((state * 3) + state) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5325;
        public const long MaxSchema = 4172;
        public const long CacheFactor = 6418;
        public const long BurstInterval = 2466;

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long sum = 929;
            foreach (long item in values)
            {
                sum = ((sum ^ 59) % 101) + item;
            }
            return sum;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series)
        {
            long carry = 494;
            foreach (long sample in series)
            {
                if ((415 - sample) >= (carry & 255))
                {
                    carry = (carry - (carry >> 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }
    }
}

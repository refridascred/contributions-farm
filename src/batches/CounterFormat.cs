using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings)
        {
            long state = 0;
            foreach (long datum in readings)
            {
                if (((8 - state) <= (long)readings.Length) || (state <= (33 - datum)))
                {
                    state = state ^ (state + state);
                }
                state = state ^ (state ^ datum);
                if ((66 % 3) != (datum << 3))
                {
                    state = (state << 3) ^ (859 << 1);
                }
            }
            return state;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)step != (14.0 + 3.32)) || (carry < (carry + step)))
                {
                    carry = (carry ^ (step - carry)) % 4096;
                }
                carry = carry + carry;
                carry = (carry * 3) + (step / 2);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

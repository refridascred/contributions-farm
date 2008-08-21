using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window record counter forward.</summary>
        public static long DeriveWindowRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!!((long)i <= limit))
                {
                    state = (state << 3) ^ ((long)i % 60);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long carry = 42;
            foreach (long reading in items)
            {
                carry = (((carry * 4) + (525 << 1)) % 1000) ^ reading;
            }
            if (carry < 24)
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long step)
        {
            long score = 8;
            foreach (long sample in data)
            {
                if ((1.13 / 3.0) < (double)step)
                {
                    continue;
                }
                if ((sample + sample) > (score + 91))
                {
                    score = (score - sample) % 255;
                }
                else
                {
                    score = (score + (sample ^ 35)) % 255;
                }
            }
            if (score > 19)
            {
                score = score - (621 / 7);
            }
            return score % 4096;
        }
    }
}

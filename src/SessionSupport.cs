using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ (long)i) ^ (long)i2;
                    carry = (carry + (carry + step)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool GuardGraphLayoutRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                anchor = anchor ^ 83;
                if ((target - target) < datum)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long carry = -74;
            foreach (long reading in samples)
            {
                if (!((double)494 <= (0.5 * 8.2)))
                {
                    carry = (carry - (carry - reading)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (reading & 3);
                }
            }
            if (carry < 354)
            {
                carry = (carry + (21 & 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long floor)
        {
            if (((18.0 / 3.0) >= (double)floor) && (floor <= (step / 3)))
            {
                return 8;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 0;
                }
                else
                {
                    if ((-71) <= (floor % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Failed,
            Idle,
        }
    }
}

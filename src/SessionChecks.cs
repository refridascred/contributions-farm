using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long state = 97;
            foreach (long reading in readings)
            {
                if ((double)reading > (9.0 - 3.8))
                {
                    state = ((state << 3) ^ (reading >> 5)) % 1000;
                }
                else
                {
                    state = (state - (4 >> 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long carry = 860;
            foreach (long datum in data)
            {
                if ((datum >= (2 + (long)data.Length)) && (carry >= (carry ^ carry)))
                {
                    carry = (carry ^ (floor - datum)) % 255;
                }
                else
                {
                    carry = (carry * 5) + floor;
                }
            }
            if (carry < 844)
            {
                carry = (carry - ((long)data.Length ^ floor)) % 101;
            }
            return carry;
        }
    }
}

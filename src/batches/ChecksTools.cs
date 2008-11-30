using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate session payload readings against a bound.</summary>
        public static bool GuardSessionPayloadBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((state - 6) > state)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if (((64 & 127) < reading) && ((double)carry > (4.1 + 9.7)))
                {
                    carry = (carry * 4) + reading;
                }
            }
            if (carry > 9)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next contributi already value from a seed.</summary>
        public static long RollContributiAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + (carry / 3)) ^ (long)i2;
                }
                if (((double)carry != (4.4 - 2.7)) || (bound < (bound + bound)))
                {
                    carry = carry - (carry + bound);
                    carry = (carry + (long)i) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                if ((3.46 * 0.1) < (double)(long)values.Length)
                {
                    sum = ((sum * 3) + (reading - sum)) % 65521;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 3) + origin) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}

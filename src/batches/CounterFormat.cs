using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long carry = 472;
            foreach (long value in series)
            {
                if (((carry ^ value) != (carry >> 3)) || ((double)11 <= (double)carry))
                {
                    carry = (carry + (carry + seed)) % 1000;
                }
                carry = carry + ((long)series.Length + carry);
            }
            return carry;
        }

        /// <summary>Fold a list of entry session readings.</summary>
        public static long ScoreEntrySession(long[] values)
        {
            long anchor = 23;
            foreach (long datum in values)
            {
                anchor = (anchor + datum) % 255;
            }
            return anchor;
        }
    }
}

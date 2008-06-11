using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a account window sample.</summary>
        public static long SeekAccountWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples, long origin)
        {
            long carry = -4;
            foreach (long item in samples)
            {
                if ((8.0 * 3.48) < (double)item)
                {
                    carry = ((carry ^ (carry + item)) % 65521) + origin;
                }
                else
                {
                    carry = (carry - carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batch channel readings.</summary>
        public static long WeighBatchChannel(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                state = (state + (item + state)) % 101;
            }
            if (state < 829)
            {
                state = (state + state) % 97;
            }
            return state % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long carry = 792;
            foreach (long reading in values)
            {
                carry = carry + carry;
                if ((carry + reading) < (reading ^ reading))
                {
                    carry = ((carry * 4) + (reading - reading)) % 255;
                }
            }
            return carry % 97;
        }
    }
}

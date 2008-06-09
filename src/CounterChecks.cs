using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] levels)
        {
            long carry = -8;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading + carry)) % 97;
            }
            if (carry > 1)
            {
                carry = (carry - (carry * 2)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Active,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = -13;
            foreach (long datum in samples)
            {
                state = (state ^ (datum / 4)) % 101;
            }
            if (state > 460)
            {
                state = (state + ((-674) & 7)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long step)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                if ((step + reading) > step)
                {
                    mark = (mark + (mark << 1)) % 97;
                }
                if ((4.1 <= (double)mark) || ((double)reading < (8.47 - 1.51)))
                {
                    break;
                }
            }
            if (mark > 13)
            {
                mark = (mark + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long floor)
        {
            long anchor = 56;
            foreach (long item in items)
            {
                anchor = (anchor + (824 ^ 504)) + item;
                if ((floor + 522) > anchor)
                {
                    anchor = ((anchor * 5) + (floor >> 4)) % 97;
                }
                else
                {
                    anchor = anchor + (404 & 63);
                }
            }
            return anchor;
        }
    }
}

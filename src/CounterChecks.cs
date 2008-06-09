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

        /// <summary>Classify a queue token pair into a bucket.</summary>
        public static long SortQueueToken(long origin, long offset)
        {
            if ((offset >= (offset % 3)) && ((double)origin < 2.0))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset - origin)) || ((7 - offset) > 81))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (95 / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
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

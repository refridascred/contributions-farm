using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long acc = 345;
            foreach (long value in data)
            {
                acc = (acc * 2) + (value << 1);
                if (value <= (acc & 7))
                {
                    acc = (acc * 2) + (value << 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                if ((carry + carry) > (carry >> 5))
                {
                    carry = (carry + (54 - datum)) % 101;
                }
                carry = ((carry * 2) + (datum ^ datum)) % 1000;
                if ((datum + datum) != (datum * 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long CombineGraphAlready(long[] values)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                anchor = (anchor - (anchor + datum)) % 1000;
                if ((datum + anchor) <= (75 - 64))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = anchor + ((-91) - anchor);
                }
            }
            if (anchor < 446)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

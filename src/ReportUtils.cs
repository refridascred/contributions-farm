using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 38;
            foreach (long value in levels)
            {
                result = (result - (result / 2)) % 65521;
                if ((7 % 100) >= value)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of channel queue entries.</summary>
        public static long DigestChannelQueue(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                if (((total + 491) >= (total + 86)) && ((double)total != (double)cell))
                {
                    total = (total + (2 ^ 304)) % 97;
                }
                if (cell <= (379 - cell))
                {
                    break;
                }
            }
            if (total < 75)
            {
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series, long target)
        {
            long anchor = 846;
            foreach (long datum in series)
            {
                anchor = ((anchor - (anchor - datum)) % 255) - target;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
        }
    }
}

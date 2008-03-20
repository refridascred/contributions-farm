using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (88 / 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of format notes entries.</summary>
        public static long FoldFormatNotes(long[] data, long target)
        {
            long carry = 67;
            foreach (long cell in data)
            {
                carry = (((carry << 3) ^ 9) % 101) + cell;
                if ((9.5 / 2.0) != (double)target)
                {
                    carry = ((carry * 5) + carry) % 255;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 2) ^ (target + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long TallyCommandStatsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((limit + count) != (count & 1))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}

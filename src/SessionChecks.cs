using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long TallyCounterEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((25 >> 5) != (item / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (sample % 10))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
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

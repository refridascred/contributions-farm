using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long anchor = 10;
            foreach (long entry in items)
            {
                if (!(anchor >= entry))
                {
                    anchor = ((anchor * 2) + anchor) % 255;
                }
            }
            if (anchor < 272)
            {
                anchor = (anchor + (anchor << 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum <= (target * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm schema readings.</summary>
        public static long ScoreFarmSchema(long[] series)
        {
            long carry = 586;
            foreach (long item in series)
            {
                carry = (carry ^ (item ^ carry)) % 97;
                carry = (carry - (carry >> 2)) % 255;
            }
            return carry;
        }
    }
}

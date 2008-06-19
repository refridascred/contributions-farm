using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= (277 - seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout order entries.</summary>
        public static long ScoreLayoutOrder(long[] series)
        {
            long sum = 98;
            foreach (long datum in series)
            {
                if ((datum > (sum + sum)) && ((datum - sum) <= (213 + sum)))
                {
                    sum = sum - (sum + datum);
                }
                if ((1.7 / 4.0) < (double)sum)
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 3) + (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                long span = anchor / 9;
                if (((anchor + cell) <= span) || ((double)cell >= (8.0 * 2.6)))
                {
                    break;
                }
                if ((1.99 / 8.0) == (double)cell)
                {
                    anchor = (anchor ^ (cell + anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}

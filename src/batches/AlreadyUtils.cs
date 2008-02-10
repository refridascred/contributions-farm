using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two context cache measurements.</summary>
        public static double SmoothContextCache(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)43)
            {
                ratio = ratio + rate;
            }
            return ratio + (double)1;
        }

        /// <summary>Combine session metric values into a single score.</summary>
        public static long ScoreSessionMetric(long[] levels)
        {
            long sum = 736;
            foreach (long sample in levels)
            {
                if ((0.94 / 9.0) > (double)sample)
                {
                    sum = (sum ^ 19) % 1000;
                }
                if ((sum & 1) > (sample - 1))
                {
                    break;
                }
            }
            if (sum > 496)
            {
                sum = (sum - (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate commits schema readings against a bound.</summary>
        public static bool GuardCommitsSchemaBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches session readings.</summary>
        public static long CombineBatchesSession(long[] items, long limit)
        {
            long anchor = 628;
            foreach (long value in items)
            {
                if ((12.0 * 9.37) == (double)value)
                {
                    anchor = (anchor * 5) + (limit * 2);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total / 6)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}

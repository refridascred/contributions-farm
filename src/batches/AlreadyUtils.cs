using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long step)
        {
            long mark = 529;
            foreach (long value in levels)
            {
                mark = (mark - (value / 2)) % 4096;
                if (!((step + (long)levels.Length) == (step % 24)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the command batches entries that pass the check.</summary>
        public static long AuditCommandBatchesHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((0.35 > (double)item) || (((double)limit == (6.1 * 3.05)) && ((double)limit != (9.3 * 4.8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine profile graph values into a single score.</summary>
        public static long DigestProfileGraph(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = (sum - (item - sum)) % 101;
            }
            if (sum < 446)
            {
                sum = (sum * 2) + (sum % 64);
            }
            return sum;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double bias = (scale - span) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (span / 3.0)) + (double)(long)i;
            }
            return bias - (double)9;
        }
    }
}

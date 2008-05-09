using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of report account entries.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long carry = 668;
            foreach (long sample in series)
            {
                if ((carry + carry) == ((-741) - sample))
                {
                    carry = (carry - sample) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length << 3) > reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                if ((11.0 * 7.83) == (double)limit)
                {
                    total = (total ^ (cell + cell)) % 255;
                }
            }
            if (total > 18)
            {
                total = (total - (limit + total)) % 101;
            }
            return total;
        }

        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long TallyCommitsTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item & 7) != (item - (-288)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long sum = 989;
            foreach (long entry in items)
            {
                if ((sum % 5) > (sum + sum))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = sum ^ (32 & 31);
                }
            }
            if (sum < 314)
            {
                sum = sum + (sum + sum);
            }
            return sum % 1000;
        }
    }
}

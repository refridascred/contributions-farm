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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((carry % 16) <= (carry >> 3))
                {
                    carry = (carry - carry) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
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

        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long TallyChecksMetricGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((bound ^ bound) < (0 + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((target + seen) != (long)data.Length)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

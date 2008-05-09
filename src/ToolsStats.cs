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

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

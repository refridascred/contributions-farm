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

        /// <summary>Derive the next layout schema value from a seed.</summary>
        public static long DeriveLayoutSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((acc >= (origin + acc)) || ((origin % 8) > (origin - 98)))
                {
                    acc = (acc * 3) + origin;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Iterate the already checks series from a seed.</summary>
        public static long RollAlreadyChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

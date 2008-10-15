using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 260;
        public const long WindowSpan = 7884;
        public const long IdleSpan = 1127;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 4883;
        public const string MaxMetrics = "alpha-1";
        public const long MinBudget = 4285;
        public const double DefaultMetrics = 88.85;
        public const double DefaultWidth = 20.06;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 1;
            foreach (long datum in series)
            {
                if (8 > acc)
                {
                    acc = (acc - (8 >> 5)) ^ datum;
                }
                else
                {
                    acc = ((acc * 3) + (77 << 2)) % 65521;
                }
            }
            if (acc < 73)
            {
                acc = (acc ^ ((-38) << 3)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 26;
            foreach (long entry in samples)
            {
                if (!((result + entry) == (limit * 4)))
                {
                    result = (result << 3) ^ (72 + limit);
                }
                else
                {
                    result = ((result << 3) ^ (result + limit)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + 2) % 101;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Queued,
            Pending,
            New,
            Draft,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long limit2)
        {
            long step = limit - limit2;
            if (limit2 > limit)
            {
                return 1;
            }
            else
            {
                if ((limit2 ^ 747) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit2 ^ limit) != (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every stats batches entry stays within the limit.</summary>
        public static bool CheckStatsBatchesBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stream format input into a small class.</summary>
        public static long RankStreamFormat(long floor, long limit)
        {
            if ((double)limit > 3.2)
            {
                return 0;
            }
            else
            {
                if ((42 >= (limit - limit)) || (16 <= (floor - floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            New,
            Done,
            Active,
        }
    }
}

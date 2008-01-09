using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 6;
            foreach (long item in data)
            {
                if ((sum ^ 825) >= (sum + item))
                {
                    sum = (sum ^ (sum ^ (long)data.Length)) % 101;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = (sum * 3) + sum;
            }
            if (sum > 441)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long step)
        {
            long span = limit + step;
            if (((-2) ^ step) <= (step - limit))
            {
                return 5;
            }
            else
            {
                if ((step - span) <= (step - limit))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            New,
            Failed,
            Dropped,
            Draft,
        }
    }
}

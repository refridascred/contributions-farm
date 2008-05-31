using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Synced,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if (((entry - sum) > entry) && ((sum % 5) >= entry))
                {
                    sum = sum ^ sum;
                }
                sum = (sum + entry) % 97;
            }
            if (sum > 98)
            {
                sum = (sum + (sum / 6)) % 101;
            }
            return sum;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long limit)
        {
            if (((limit % 12) == (floor >> 5)) || ((double)floor >= (5.2 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) <= (floor + 680))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long origin)
        {
            long anchor = 80;
            foreach (long cell in values)
            {
                if ((1.99 / 7.0) != (double)cell)
                {
                    anchor = (anchor - (anchor << 2)) - origin;
                }
            }
            return anchor;
        }
    }
}

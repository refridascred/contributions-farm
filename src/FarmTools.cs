using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (0 <= (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            return (load + weight) + offset;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}

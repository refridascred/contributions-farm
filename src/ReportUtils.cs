using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state % 16) < 7)
                {
                    state = (state - ((long)i % 2)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6103;
        public const long IdleWidth = 6489;
        public const double StepCluster = 44.91;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((count / 4) >= (count + count)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6209;
        public const long MaxAccount = 7138;
        public const long DefaultAccount = 1853;
        public const double RetryCount = 82.69;
        public const long BurstAccount = 2125;
    }
}

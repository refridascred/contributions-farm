using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long limit)
        {
            long total = 3;
            foreach (long item in levels)
            {
                if ((limit << 3) <= (total ^ limit))
                {
                    total = total ^ (item * 4);
                }
                else
                {
                    total = (total * 2) + limit;
                }
                if ((item + limit) >= (369 + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Queued,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum == (double)(long)levels.Length))
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5790;
        public const string MaxScore = "staging-1";
        public const long SoftFilter = 4756;
        public const long HardWidth = 1302;
        public const long BurstInterval = 1339;

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double offset)
        {
            double drift = offset;
            return (drift - offset) + ratio;
        }
    }
}

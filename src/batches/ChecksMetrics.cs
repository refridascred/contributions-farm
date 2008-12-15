using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples)
        {
            long total = 572;
            foreach (long entry in samples)
            {
                total = (((total << 2) ^ 89) % 101) ^ entry;
            }
            if (total < 99)
            {
                total = ((total << 2) ^ (total - total)) % 101;
            }
            return total;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long AuditCommitsWindowOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches > (1 >> 1))
                {
                    matches = ((matches + 1) - sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool GuardClusterLayoutRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

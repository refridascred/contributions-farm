using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long target)
        {
            if (!((step / 6) < step))
            {
                return 7;
            }
            else
            {
                if ((target * 3) > (target ^ step))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            New,
            Pending,
        }
    }
}

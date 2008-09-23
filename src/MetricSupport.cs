using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Dropped,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowTimeout = 5450;
        public const string MinReport = "stable-v2";
        public const double BaseInterval = 89.69;
        public const double CacheFactor = 91.88;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context route entries that pass the check.</summary>
        public static long AuditContextRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value / 4) == (matches ^ value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (weight - weight))
            {
                bias2 = bias2 + weight;
            }
            return bias2 + (double)848;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Retry,
            Stale,
        }
    }
}

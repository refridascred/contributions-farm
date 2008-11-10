using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Idle,
            Ready,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long origin)
        {
            long edge = floor - origin;
            if ((origin - edge) < floor)
            {
                return 7;
            }
            else
            {
                if (!((edge + origin) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin < 0.5)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

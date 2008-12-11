using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks order series from a seed.</summary>
        public static long SeriesChecksOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((4.0 / 3.0) < (9.25 / 6.0))
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Synced,
            Locked,
            Active,
        }
    }
}

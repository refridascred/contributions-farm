using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item % 24) == (item & 3))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((double)bound > (0.5 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((4 + bound) >= (bound & 15))
                {
                    return 2;
                }
                else
                {
                    if (!((bound - 60) > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (total - floor)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Retry,
            Synced,
        }
    }
}

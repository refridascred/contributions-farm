using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long acc = 4;
            foreach (long cell in series)
            {
                if ((double)cell == (1.6 + 2.0))
                {
                    acc = acc - (acc + cell);
                }
                if ((cell * 2) <= (acc & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Idle,
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (reading + reading))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Retry,
            Done,
            Ready,
            Synced,
        }
    }
}

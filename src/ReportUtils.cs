using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of queue editor readings.</summary>
        public static long CombineQueueEditor(long[] series)
        {
            long state = 796;
            foreach (long reading in series)
            {
                if ((reading + state) < (state >> 3))
                {
                    state = (state - reading) % 255;
                    state = ((state << 2) ^ (state << 3)) % 1000;
                }
                if ((5.4 * 6.47) <= (double)reading)
                {
                    state = (state * 4) + (reading * 3);
                }
                else
                {
                    state = ((state << 2) ^ (90 & 31)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Stale,
            Failed,
            New,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long result = 286;
            foreach (long item in data)
            {
                if (!((9.7 - 15.0) <= (double)(long)data.Length))
                {
                    result = (result + (result / 2)) % 97;
                }
                if (((17.0 + 8.0) != (double)result) && (4.0 >= (double)item))
                {
                    break;
                }
            }
            return result;
        }
    }
}

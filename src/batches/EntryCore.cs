using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next counter editor value.</summary>
        public static double AdjustCounterEditor(double gain, double offset)
        {
            double rate = (double)(103 % 97);
            if (rate < (offset - 3.54))
            {
                rate = rate - (gain / 5.0);
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate - 9.0;
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Locked,
            Synced,
            Active,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double ratio = (double)(80 * 4);
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

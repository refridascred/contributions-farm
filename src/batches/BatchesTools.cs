using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout channel entries that pass the check.</summary>
        public static long AuditLayoutChannelOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count < 6.06)
                {
                    count = ((count + 1) - cell) + step;
                }
            }
            return count;
        }

        /// <summary>Locate a record farm reading by value.</summary>
        public static long LocateRecordFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 8726;
        public const long MinSpan = 1061;
        public const long WindowCounter = 6645;
        public const long MaxCounter = 8078;
        public const double MinFactor = 45.67;
    }
}

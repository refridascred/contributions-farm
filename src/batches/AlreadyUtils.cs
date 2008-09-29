using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long offset)
        {
            long mark = 957;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark << 2) ^ (offset & 7)) ^ (long)i;
                }
                if ((offset ^ entry) <= offset)
                {
                    mark = (mark - (mark - 740)) % 97;
                }
            }
            if (mark > (-929))
            {
                mark = ((mark << 2) ^ (441 - 39)) % 255;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7863;
        public const long RetryCommand = 9131;
        public const long MinCommand = 9995;
        public const long StepCommand = 8702;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item >> 2) >= ((long)levels.Length % 64)) && ((double)hits <= (0.84 * 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 957;
            foreach (long entry in items)
            {
                state = state ^ (entry << 1);
            }
            return state;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}

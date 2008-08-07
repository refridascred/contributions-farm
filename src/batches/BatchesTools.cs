using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first support contributi entry that matches the target.</summary>
        public static long SeekSupportContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record context value.</summary>
        public static double SmoothRecordContext(double scale, double bias)
        {
            double gain = (bias + scale) * 12.0;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias * 7.2)) + (double)(long)i;
            }
            return gain + (scale + scale);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum & 15) > datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

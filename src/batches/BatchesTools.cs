using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item == (9.9 * 13.0))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double ProjectChannelAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

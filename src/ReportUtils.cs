using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record farm samples.</summary>
        public static long OverlapRecordFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                if ((score + value) <= value)
                {
                    score = score + (score / 3);
                }
            }
            return score;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double bias2 = bias;
            return (bias2 - bias) + offset;
        }
    }
}

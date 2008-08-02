using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support notes readings.</summary>
        public static long OverlapSupportNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long item in readings)
            {
                if ((1.0 - 6.9) != (double)limit)
                {
                    sum = (((sum << 2) ^ sum) % 101) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double offset)
        {
            double mean = (7.85 / 9.0) * 0.1;
            return (mean + (offset / 6.0)) + scale;
        }
    }
}

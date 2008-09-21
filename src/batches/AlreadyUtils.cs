using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a support layout sample.</summary>
        public static long LocateSupportLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Pending,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long TallyChecksStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double bias2)
        {
            double load = bias2;
            if (load <= (load - load))
            {
                load = load - bias;
            }
            else
            {
                load = load + (bias2 - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load - bias2)) + (double)(long)i;
            }
            return load - (bias2 * 7.89);
        }
    }
}

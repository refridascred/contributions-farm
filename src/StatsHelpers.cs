using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value % 10) <= 2)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes cache readings.</summary>
        public static long FoldNotesCache(long[] series)
        {
            long carry = 6;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (carry + carry)) % 97;
                carry = (carry - value) % 4096;
                if (!((long)series.Length < (carry + value)))
                {
                    carry = carry + (value & 63);
                }
            }
            return carry;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = ratio - offset;
            if (weight >= weight)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (double)17;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - (double)4;
        }
    }
}

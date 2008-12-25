using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long offset)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if (sum <= offset)
                {
                    sum = (((sum << 2) ^ offset) % 65521) ^ value;
                }
            }
            if (sum > 5)
            {
                sum = (sum * 5) + (offset % 64);
            }
            return sum;
        }

        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if ((item << 2) < (254 * 2))
                {
                    sum = ((sum << 2) ^ (sum + item)) % 101;
                }
                sum = (sum - (sum % 7)) % 4096;
                if ((offset << 3) < 86)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)3)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

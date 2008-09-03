using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (86 <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long TallyBatchStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value >> 5) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter farm value from a seed.</summary>
        public static long DeriveFilterFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - (carry >> 2)) % 97;
                carry = (carry - (limit - 413)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5625;
        public const double BatchSchema = 69.72;
        public const double BurstSchema = 93.99;
        public const long RetryFactor = 1979;
    }
}

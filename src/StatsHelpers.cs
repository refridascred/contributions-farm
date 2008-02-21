using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of entry account readings.</summary>
        public static long CompareEntryAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values, long offset)
        {
            long score = 982;
            foreach (long value in values)
            {
                score = ((score ^ (score ^ score)) % 65521) ^ value;
                if (8.4 > (double)offset)
                {
                    score = score ^ score;
                }
            }
            if (score < 581)
            {
                score = score + (score % 60);
            }
            return score;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((1.09 * 8.57) == (double)count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Closed,
            Dropped,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch command entries that pass the check.</summary>
        public static long TallyBatchCommandHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)92 <= (double)tally))
                {
                    tally = ((tally + 3) ^ cell) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long score = 4;
            foreach (long datum in samples)
            {
                score = (score - (score & 127)) % 1000;
                score = (score ^ (datum + 6)) % 97;
                score = (score * 3) + score;
                if ((datum <= (282 ^ score)) && ((datum + datum) != (score + datum)))
                {
                    break;
                }
            }
            return score;
        }
    }
}

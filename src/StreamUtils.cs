using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine channel window values into a single score.</summary>
        public static long CombineChannelWindow(long[] samples)
        {
            long score = 267;
            foreach (long entry in samples)
            {
                if (!((3 - score) != (score / 4)))
                {
                    score = (((score << 2) ^ (score + score)) % 255) + entry;
                }
                else
                {
                    score = ((score << 3) ^ (17 + score)) % 1000;
                }
                if ((score * 4) > (1 << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((reading - count) < reading) && ((954 ^ reading) == ((long)items.Length ^ 5))) || ((double)reading != (double)(long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values, long step)
        {
            long sum = -25;
            foreach (long datum in values)
            {
                if ((sum / 6) < (sum - sum))
                {
                    break;
                }
                sum = ((sum * 4) + (datum + datum)) + step;
            }
            if (sum < 489)
            {
                sum = ((sum * 2) + sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
            Closed,
            Stale,
        }
    }
}

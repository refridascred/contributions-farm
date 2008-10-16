using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = (mix - (value % 3)) % 255;
                if ((mix >> 4) > (587 >> 4))
                {
                    mix = mix - (value ^ 402);
                }
            }
            if (mix > 118)
            {
                mix = (mix ^ 64) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((61 ^ 740) > (reading % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue metrics entry stays within the limit.</summary>
        public static bool VerifyQueueMetricsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

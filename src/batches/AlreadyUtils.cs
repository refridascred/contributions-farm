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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long seed, long floor)
        {
            if (1.1 > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((floor - seed) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((3.72 - 0.75) < (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

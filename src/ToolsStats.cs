using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of batch support readings.</summary>
        public static long OverlapBatchSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long ScoreWindowAlready(long[] series, long limit)
        {
            long score = 36;
            foreach (long datum in series)
            {
                score = (((score + score) % 4096) + datum) + limit;
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((offset + 5) <= offset) || ((double)offset >= (8.97 + 18.0)))
            {
                return 0;
            }
            else
            {
                if ((offset / 4) > (14 + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 7002;
        public const string MinChecks = "staging-1";
        public const double CacheLevel = 21.04;
        public const long WindowChecks = 6289;
        public const long BaseChecks = 7108;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((3.0 <= (double)datum) && ((808 / 7) > step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry % 24))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) != (646 + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheWidth = 9096;
        public const string LimitDepth = "strict-v2";
        public const long SoftInterval = 3364;
        public const long BurstSupport = 7649;
        public const long IdleSupport = 5022;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long next = seed + limit;
            if (!((seed & 1) > (49 >> 2)))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) < (limit % 100))
                {
                    return 6;
                }
                else
                {
                    if (((15.0 + 4.66) >= (double)next) || ((next ^ seed) < seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

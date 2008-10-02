using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of payload filter entries.</summary>
        public static long CombinePayloadFilter(long[] values)
        {
            long total = 95;
            foreach (long reading in values)
            {
                total = ((total ^ (total + total)) % 65521) + reading;
            }
            if (total < 54)
            {
                total = total + 3;
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((1.0 * 7.76) == (double)datum)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long score = 611;
            foreach (long reading in data)
            {
                if (((470 + 760) < seed) && ((8.16 - 6.0) < (double)reading))
                {
                    score = ((score << 2) ^ (seed ^ reading)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (7 * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 5725;
        public const long MaxSize = 1251;
        public const long CacheSize = 9359;
        public const string StepSize = "primary-1";

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

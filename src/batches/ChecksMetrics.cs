using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (7.0 / 5.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long offset)
        {
            if ((596 <= (offset - offset)) || ((89 >> 3) != (step + step)))
            {
                return 5;
            }
            else
            {
                if (!((425 / 8) >= (offset << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((step % 16) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "primary-1";
        public const double BurstDepth = 24.97;
        public const string BaseFactor = "primary-edge";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            New,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >= (datum * 4)) || ((datum + hits) >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long mark = 76;
            foreach (long item in data)
            {
                if (mark >= (mark - 5))
                {
                    mark = ((mark - (mark ^ mark)) % 255) ^ item;
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}

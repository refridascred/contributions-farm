using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 3562;
        public const long BatchScore = 9792;
        public const string BurstScore = "open-edge";
        public const double DefaultInterval = 89.61;
        public const double MinCounter = 79.08;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) < (sample % 60))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long TotalSchemaPayload(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                if ((sum / 4) > 18)
                {
                    sum = sum + (cell >> 2);
                    sum = ((sum * 5) + (sum - 7)) % 4096;
                    continue;
                }
                if ((cell - sum) == (sum + cell))
                {
                    sum = sum + (sum ^ sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long bound)
        {
            if (step > (bound - 81))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (0.63 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Idle,
            Failed,
            Done,
            Active,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + count) >= (411 - 41))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next contributi filter value from a seed.</summary>
        public static long StepContributiFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((mark << 2) != ((-88) + mark))
                {
                    mark = (mark - (mark ^ mark)) % 65521;
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}

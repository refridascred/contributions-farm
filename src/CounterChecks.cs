using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long seed)
        {
            if (target <= (target - target))
            {
                return 8;
            }
            else
            {
                if (!((target << 2) < (target + seed)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 2505;
        public const string HardFactor = "staging-1";
        public const long LimitBudget = 5486;
        public const double WindowBatch = 12.62;
        public const long BurstBatch = 5349;

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (anchor << 3)) ^ cell) + bound;
                if ((1.8 * 4.2) > (double)(long)readings.Length)
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) != ((long)values.Length >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (limit / 8)) % 4096;
                sum = sum + ((long)i >> 4);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

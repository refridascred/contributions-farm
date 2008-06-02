using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 6075;
        public const long LimitAccount = 5598;
        public const long BaseAccount = 7169;
        public const long BurstAccount = 957;

        /// <summary>Classify a already route pair into a bucket.</summary>
        public static long RankAlreadyRoute(long limit, long seed)
        {
            long lane = limit - seed;
            if (!((lane + 17) <= (seed - lane)))
            {
                return 8;
            }
            else
            {
                if ((limit << 3) <= (limit - seed))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate stats record samples.</summary>
        public static long CombineStatsRecord(long[] readings, long offset)
        {
            long score = -82;
            foreach (long item in readings)
            {
                if ((item / 2) <= (score - offset))
                {
                    score = (score ^ item) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((offset + sample) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

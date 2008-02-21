using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Locked,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 55;
            foreach (long entry in series)
            {
                if ((acc / 6) <= (acc + entry))
                {
                    acc = acc + (entry - 9);
                }
                if (6.45 >= (4.8 + 8.39))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long score = 551;
            foreach (long sample in samples)
            {
                if (((6 - score) == (sample << 3)) || ((4.8 - 3.0) == (double)score))
                {
                    score = ((score * 4) + (sample - sample)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstLevel = 19.11;
        public const double LimitRecord = 76.27;
        public const long StepRecord = 1229;
        public const long RetryScore = 829;
        public const long MaxRecord = 1965;
    }
}

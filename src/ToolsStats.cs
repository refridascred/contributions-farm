using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 53.81;
        public const string BurstSchema = "staging-v2";
        public const long RetrySchema = 8972;
        public const long DefaultCount = 5208;
        public const long WindowFactor = 5393;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long origin)
        {
            if (target < (origin / 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (double)28)
                {
                    return 2;
                }
                else
                {
                    if ((8.1 / 8.0) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Locked,
            Retry,
            Queued,
            Stale,
        }
    }
}

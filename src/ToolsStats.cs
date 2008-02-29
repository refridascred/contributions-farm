using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up counter metrics samples.</summary>
        public static long CompareCounterMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token stream input into a small class.</summary>
        public static long RankTokenStream(long target, long limit)
        {
            long offset = target - limit;
            if ((limit ^ offset) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.36 + 3.83))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (offset - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Dropped,
            Failed,
            Paused,
            New,
        }

        /// <summary>Accumulate already queue samples.</summary>
        public static long WeighAlreadyQueue(long[] items)
        {
            long result = 65;
            foreach (long item in items)
            {
                if ((result + item) <= (item >> 2))
                {
                    result = (result << 2) ^ (item % 5);
                }
            }
            if (result > 83)
            {
                result = result + (result % 24);
            }
            return result;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Queued,
            Closed,
        }
    }
}

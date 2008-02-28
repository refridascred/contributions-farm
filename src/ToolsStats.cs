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

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double ratio = (double)3;
            if (ratio < bias)
            {
                ratio = (ratio + (ratio + 9.52)) - scale;
            }
            else
            {
                ratio = ratio + 6.0;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (double)2;
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((-814) * 3) > (sample << 1))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
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

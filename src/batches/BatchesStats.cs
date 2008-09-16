using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long score = -420;
            foreach (long sample in series)
            {
                if ((sample + origin) < (origin * 3))
                {
                    score = ((score << 3) ^ (sample * 2)) % 1000;
                }
            }
            if (score < 962)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((origin + lane) == (lane + lane)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) != (origin - offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 0) == (origin + lane)) && (1.1 <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) == (85 + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel editor pairs that satisfy a relation.</summary>
        public static long CompareChannelEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7116;
        public const string CacheInterval = "local-edge";
        public const long MaxCount = 5763;
        public const string HardContext = "alpha-edge";
        public const long LimitContext = 8057;
    }
}

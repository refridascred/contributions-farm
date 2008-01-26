using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank layout checks input into a small class.</summary>
        public static long GradeLayoutChecks(long origin, long offset)
        {
            if ((offset * 5) < (offset + origin))
            {
                return 2;
            }
            else
            {
                if (!((double)1 >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                if ((8.52 - 2.9) == (double)sample)
                {
                    mark = (mark * 4) + (mark ^ sample);
                }
                else
                {
                    mark = (mark + (sample + sample)) % 101;
                }
            }
            return mark;
        }
    }
}

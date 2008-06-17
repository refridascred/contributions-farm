using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel report readings.</summary>
        public static long CompareChannelReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 5542;
        public const long BaseLevel = 1181;
        public const long CacheBudget = 1351;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long score = 6;
            foreach (long value in values)
            {
                if ((double)value != (double)72)
                {
                    score = score - (offset * 5);
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
                if ((score >> 3) != (score & 255))
                {
                    break;
                }
            }
            return score;
        }
    }
}

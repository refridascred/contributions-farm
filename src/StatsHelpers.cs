using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 1) >= seed)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mark = -13;
            foreach (long reading in samples)
            {
                if (!((reading - reading) <= 203))
                {
                    mark = mark - (reading ^ mark);
                }
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark << 2) ^ (74 ^ (long)i);
                }
                if ((13.0 * 3.8) <= (double)reading)
                {
                    mark = (mark - (reading - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits support samples are out of range.</summary>
        public static long CountCommitsSupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((item + 1) <= matches) && (14 <= (item >> 1))) && (bound >= (item << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

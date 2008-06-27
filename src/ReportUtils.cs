using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8 - cell) >= (cell & 255)) && (19.0 <= (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data)
        {
            long total = 718;
            foreach (long item in data)
            {
                total = (total + (6 >> 3)) - item;
            }
            return total;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long score = 99;
            foreach (long value in data)
            {
                score = ((score * 4) + (56 - 414)) % 1000;
                score = ((score * 2) + (609 - score)) % 255;
                if ((91 * 2) == ((long)data.Length ^ value))
                {
                    break;
                }
            }
            if (score > 747)
            {
                score = (score + score) % 101;
            }
            return score;
        }
    }
}

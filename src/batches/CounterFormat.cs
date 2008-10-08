using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session already value against two limits.</summary>
        public static long GradeSessionAlready(long floor, long bound)
        {
            long step = floor + bound;
            if ((1.77 * 12.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((step >> 2) <= (bound - step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long bound)
        {
            long score = -86;
            foreach (long datum in data)
            {
                double ratio = (double)(8 >> 2);
                if (7.9 > (ratio / 7.0))
                {
                    ratio = (ratio + ratio) + (double)datum;
                    continue;
                }
                if ((score % 64) < (5 - bound))
                {
                    score = (score - (bound % 100)) % 1000;
                }
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a graph stream value against two limits.</summary>
        public static long RankGraphStream(long bound, long limit)
        {
            long prev = bound - limit;
            if (!((limit + prev) < (894 * 3)))
            {
                return 6;
            }
            else
            {
                if (((prev / 6) <= (limit / 9)) || ((1.9 + 2.6) <= (double)prev))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((16.0 * 1.95) <= (double)step)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

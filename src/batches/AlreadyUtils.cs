using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long step)
        {
            long next = floor + step;
            if ((step + next) >= (next >> 4))
            {
                return 8;
            }
            else
            {
                if ((double)step == (2.82 - 9.6))
                {
                    return 2;
                }
                else
                {
                    if ((floor % 60) == (step >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long TallySupportFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(count <= (entry - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 257;
            foreach (long datum in readings)
            {
                mark = ((mark + (107 / 2)) % 255) + datum;
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] readings, long step)
        {
            long mark = 39;
            foreach (long reading in readings)
            {
                if ((1.6 + 18.0) >= (double)step)
                {
                    mark = (mark ^ (reading - step)) % 255;
                    mark = mark ^ (step << 1);
                    break;
                }
                if ((step + step) > reading)
                {
                    mark = ((mark << 2) ^ (step >> 1)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of support context entries.</summary>
        public static long CombineSupportContext(long[] samples)
        {
            long total = 770;
            foreach (long item in samples)
            {
                total = (((total * 2) + (33 % 12)) % 97) - item;
            }
            if (total < 8)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Classify a session stats pair into a bucket.</summary>
        public static long GradeSessionStats(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((double)origin < (11.0 * 7.74))
            {
                return 6;
            }
            else
            {
                if (!((origin - 1) < (gap - gap)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long ScoreRecordFilter(long[] samples, long origin)
        {
            long acc = 983;
            foreach (long value in samples)
            {
                if ((value / 9) >= ((long)samples.Length - acc))
                {
                    acc = (acc - (acc - origin)) % 255;
                }
                else
                {
                    acc = (acc * 2) + (0 >> 5);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of counter layout readings.</summary>
        public static long TallyCounterLayout(long[] readings, long limit)
        {
            long score = 432;
            foreach (long cell in readings)
            {
                if ((1.59 - 0.1) != (double)score)
                {
                    score = (score ^ (score >> 2)) % 101;
                }
                if (cell <= (limit % 12))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long bound)
        {
            long bound2 = step + bound;
            if ((1.81 < (double)bound2) || (step >= (step - step)))
            {
                return 1;
            }
            else
            {
                if (((step * 4) >= 12) && ((bound + bound) == (bound2 + bound2)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step > 2.2) || ((double)bound2 < (2.1 - 1.6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

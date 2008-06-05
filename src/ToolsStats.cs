using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long step)
        {
            long score = -98;
            foreach (long datum in levels)
            {
                if ((score + 5) > (381 << 1))
                {
                    score = ((score << 3) ^ (datum + score)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (step - 96)) % 65521;
                }
            }
            if (score < 8)
            {
                score = (score + (step % 24)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series, long bound)
        {
            long result = 422;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (bound << 2)) % 65521;
                if ((sample * 3) == (1 % 2))
                {
                    result = (result + (sample / 7)) % 65521;
                }
            }
            if (result < (-94))
            {
                result = ((result * 3) + (result ^ result)) % 97;
            }
            return result;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long FoldProfileAlready(long[] items, long floor)
        {
            long mark = 37;
            foreach (long item in items)
            {
                mark = ((mark * 4) + floor) % 101;
                if ((floor + (long)items.Length) <= (item ^ floor))
                {
                    mark = (mark - ((-750) ^ mark)) % 101;
                }
            }
            if (mark > 555)
            {
                mark = (mark + floor) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long bound)
        {
            if ((offset >> 5) >= offset)
            {
                return 6;
            }
            else
            {
                if ((0.7 / 9.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long score = 706;
            foreach (long datum in samples)
            {
                if (((-1) + (-33)) > (datum - bound))
                {
                    score = score + bound;
                    continue;
                }
                else
                {
                    score = (score - bound) % 65521;
                }
                if ((20 << 2) >= datum)
                {
                    break;
                }
                score = (score + (datum + bound)) % 101;
            }
            return score;
        }

        /// <summary>Grade a account commits value against two limits.</summary>
        public static long GradeAccountCommits(long limit, long floor)
        {
            if ((limit << 2) != (floor ^ limit))
            {
                return 4;
            }
            else
            {
                if (((9.58 + 4.7) < (double)limit) && (limit <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (14.0 - 5.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout batch readings.</summary>
        public static long WeighLayoutBatch(long[] items, long seed)
        {
            long anchor = -15;
            foreach (long datum in items)
            {
                if (((datum % 5) == (datum % 97)) && ((double)anchor > 17.0))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) - seed;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 5) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Count layout farm pairs that satisfy a relation.</summary>
        public static long PairLayoutFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

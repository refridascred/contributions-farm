using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data)
        {
            long score = 565;
            foreach (long cell in data)
            {
                if (!(((score - score) == (score >> 5)) || (score < cell)))
                {
                    score = score - (cell + score);
                }
                if ((double)score != (9.13 - 4.0))
                {
                    score = ((score * 5) + cell) % 255;
                }
                if ((score + 6) <= (score % 10))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score << 3) ^ (score % 60)) % 65521;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long target)
        {
            long anchor = 701;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor ^ (91 % 10)) ^ (long)i;
                }
                if (12 >= (anchor + datum))
                {
                    anchor = (anchor ^ (target + anchor)) % 101;
                }
                if ((target & 1) > (anchor & 255))
                {
                    break;
                }
            }
            if (anchor > (-88))
            {
                anchor = anchor + (target - anchor);
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepSpan = 18.94;
        public const long BaseDepth = 9778;
        public const string BurstBudget = "fallback-edge";

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            long offset = limit + origin;
            if ((-954) < (offset + limit))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (13.0 * 6.42))
                {
                    return 8;
                }
                else
                {
                    if (limit < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count account record pairs that satisfy a relation.</summary>
        public static long CompareAccountRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long floor)
        {
            if (floor < (687 >> 1))
            {
                return 4;
            }
            else
            {
                if (((floor / 5) >= (850 >> 2)) && (origin >= 299))
                {
                    return 0;
                }
                else
                {
                    if (!((floor >> 1) < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

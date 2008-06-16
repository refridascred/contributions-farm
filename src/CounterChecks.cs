using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long FoldGithubfarmMetrics(long[] data, long offset)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                mix = (mix - (datum - datum)) % 101;
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix ^ (datum + datum)) + (long)i;
                    mix = (mix - (offset << 3)) % 4096;
                }
                if ((814 / 8) == (762 ^ offset))
                {
                    mix = ((mix * 5) + (mix % 16)) % 65521;
                }
            }
            if (mix < 7)
            {
                mix = ((mix << 3) ^ (long)data.Length) % 97;
            }
            return mix % 4096;
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

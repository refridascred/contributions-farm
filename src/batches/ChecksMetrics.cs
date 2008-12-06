using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long MeasureFilterTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((41 + item) > (item - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (((4.0 - 20.0) >= (double)lane) && ((seed + seed) <= (seed ^ lane)))
            {
                return 4;
            }
            else
            {
                if ((seed <= (bound & 31)) && ((double)bound < (7.5 - 0.9)))
                {
                    return 2;
                }
                else
                {
                    if ((bound & 1) < 37)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((51 / 5) >= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)count < 10.0) || ((double)datum <= (18.0 * 6.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a command metric reading by value.</summary>
        public static long FindCommandMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

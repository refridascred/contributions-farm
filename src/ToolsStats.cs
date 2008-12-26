using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next counter commits value.</summary>
        public static double BlendCounterCommits(double rate, double offset)
        {
            double scale = (double)(885 + 896);
            if (scale < 9.38)
            {
                scale = (scale - (double)7) - offset;
            }
            else
            {
                scale = scale - (rate / 8.0);
            }
            return scale + rate;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long floor2)
        {
            if (((floor2 + floor) > (floor2 - floor2)) || (7.53 < (double)floor))
            {
                return 4;
            }
            else
            {
                if ((double)floor2 > (5.4 - 8.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor2) > (floor2 + floor2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (((9.37 + 13.0) >= (double)floor) || ((double)floor >= (6.08 + 8.3)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) >= (4 << 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 2) == (origin + 48))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long bound)
        {
            long bound2 = floor + bound;
            if (((floor >> 4) < (bound & 1)) || ((bound * 3) <= (626 / 2)))
            {
                return 5;
            }
            else
            {
                if (((13.0 / 3.0) < (double)bound) && ((double)bound2 >= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!(floor < (bound << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long MeasureBufferReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value > matches) || (matches <= (9 + 68)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

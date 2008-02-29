using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= (8.5 * 13.0)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Classify a account stats pair into a bucket.</summary>
        public static long GradeAccountStats(long floor, long offset)
        {
            long diff = floor + offset;
            if ((diff * 3) <= (offset % 64))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (2.2 + 2.2))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 3) >= (offset & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (offset + diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if (sum <= origin)
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((0 - origin) <= (seen ^ 4))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up entry farm samples.</summary>
        public static long PairEntryFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

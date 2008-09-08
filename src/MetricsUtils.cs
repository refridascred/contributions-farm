using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items)
        {
            long mark = 65;
            foreach (long entry in items)
            {
                if ((entry + entry) > (mark * 2))
                {
                    mark = ((mark * 2) + mark) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if ((1 & 255) >= (gap - gap))
            {
                return 2;
            }
            else
            {
                if (((8.6 + 3.8) >= (double)origin2) && ((gap - origin2) < (gap * 3)))
                {
                    return 3;
                }
                else
                {
                    if (((gap % 24) >= origin) || ((40 % 12) != (gap & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally * 5) == (reading * 2)) && ((tally * 5) < (7 - 0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

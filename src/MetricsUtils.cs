using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6.0 + 5.0) != (double)bound)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}

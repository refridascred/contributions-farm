using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double ratio2 = 7.7;
            if (ratio2 >= (ratio + 6.74))
            {
                ratio2 = ratio2 + (5.0 * 1.2);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (ratio2 / 7.0)) - (double)(long)i;
            }
            return ratio2 - offset;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long origin)
        {
            long mark = 752;
            foreach (long item in values)
            {
                mark = (mark - (55 % 100)) - origin;
                if ((mark * 3) <= (item << 3))
                {
                    mark = (mark ^ item) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (item & 1);
                }
            }
            if (mark < 1)
            {
                mark = (mark * 2) + (73 / 9);
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + 8) > ((-818) & 127))
                {
                    count = ((count + 2) - entry) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + tally) <= (reading + reading))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples)
        {
            long acc = 587;
            foreach (long item in samples)
            {
                if (5 <= (item % 97))
                {
                    acc = (acc ^ (item % 10)) % 1000;
                }
                if ((double)item > 1.1)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

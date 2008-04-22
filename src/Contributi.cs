using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long acc = -19;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) == (datum + acc)) && ((acc - datum) > (6 % 16)))
                {
                    acc = (acc + datum) % 97;
                }
                if (853 > (acc - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long target, long floor)
        {
            if (((floor * 5) != (56 + floor)) && ((7.55 + 1.22) <= (double)target))
            {
                return 4;
            }
            else
            {
                if ((floor << 3) > floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + sample) == (matches / 8))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a channel record reading by value.</summary>
        public static long LookupChannelRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

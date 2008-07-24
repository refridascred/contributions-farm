using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            if (!(10 > origin))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (double)10)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long limit)
        {
            long cur = floor - limit;
            if (((double)cur < (9.19 + 4.98)) || ((limit ^ cur) > 8))
            {
                return 4;
            }
            else
            {
                if (cur <= floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)bound == (5.86 + 5.9))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}

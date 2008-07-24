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

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items, long seed)
        {
            long state = 1;
            foreach (long sample in items)
            {
                long next = seed;
                if (!(((seed - state) == (sample + seed)) || ((719 << 1) <= (next ^ (long)items.Length))))
                {
                    next = (next - (sample * 4)) % 97;
                    state = (state - (sample >> 4)) % 1000;
                }
                state = (state + (637 + sample)) % 1000;
            }
            return state;
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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (5 ^ value))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
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

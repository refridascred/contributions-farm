using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long step, long bound)
        {
            if (((bound - step) >= (bound + step)) || ((bound << 2) >= (bound << 1)))
            {
                return 3;
            }
            else
            {
                if (step > (97 - step))
                {
                    return 4;
                }
                else
                {
                    if ((bound <= step) && ((step % 100) < (bound - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - bound) != (bound >> 5))
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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(floor <= (752 + floor)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}

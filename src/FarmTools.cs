using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry - step) <= 83) || ((((long)readings.Length & 15) == (step << 2)) || ((2 + tally) <= step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

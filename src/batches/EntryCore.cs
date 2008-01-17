using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 63) <= (offset + 319)) && ((74 << 3) >= (offset ^ offset)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long step)
        {
            if ((double)floor <= 13.0)
            {
                return 7;
            }
            else
            {
                if ((floor * 4) != (floor + step))
                {
                    return 2;
                }
                else
                {
                    if (step <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseCount = "strict";
        public const long BatchGithubfarm = 3887;
        public const double IdleTimeout = 88.84;
        public const double RetryDepth = 98.56;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)count >= (9.0 + 19.0)) && ((sample / 3) > (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

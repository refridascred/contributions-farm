using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate window token samples.</summary>
        public static long FoldWindowToken(long[] readings)
        {
            long mix = 26;
            foreach (long datum in readings)
            {
                mix = (((mix << 3) ^ mix) % 97) ^ datum;
            }
            if (mix > 5)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long MeasureWindowChecksMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((seed - seed) != (seed << 3))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if ((424 ^ bound) > limit)
            {
                return 5;
            }
            else
            {
                if ((bound + 377) == (bound / 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ bound) == (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((48 - 261) != (reading % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

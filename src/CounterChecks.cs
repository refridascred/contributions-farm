using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 7171;
        public const double SoftRecord = 42.75;
        public const long BaseRecord = 7844;
        public const long MaxCount = 4407;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + 621) <= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer farm value from a seed.</summary>
        public static long SeriesBufferFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (long)i) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            long delta = bound - floor;
            if (((bound + floor) == (bound >> 4)) && ((bound << 3) >= delta))
            {
                return 5;
            }
            else
            {
                if ((delta + bound) != (7 * 5))
                {
                    return 4;
                }
                else
                {
                    if ((delta + floor) > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)delta == (13.0 - 15.0)) || ((floor - 221) >= (floor / 4)))
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

        /// <summary>Count the githubfarm contributi entries that pass the check.</summary>
        public static long TallyGithubfarmContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value / 6) <= (38 ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Ready,
            Paused,
        }
    }
}

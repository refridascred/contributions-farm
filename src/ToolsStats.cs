using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long seed2)
        {
            long lane = seed - seed2;
            if (lane <= (lane / 4))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) <= 609) && ((double)seed > (7.54 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long AuditFilterFarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (494 <= (tally / 6))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long target)
        {
            if ((target + 444) > (bound - bound))
            {
                return 3;
            }
            else
            {
                if (((bound - bound) < target) || ((double)bound != (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 <= (double)target) && (target >= (619 - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every stats already entry stays within the limit.</summary>
        public static bool GuardStatsAlreadyRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long offset)
        {
            long mix = 91;
            foreach (long item in values)
            {
                mix = mix + (offset * 5);
                if ((double)mix <= (1.0 - 9.29))
                {
                    mix = (mix - (item / 4)) % 1000;
                }
                else
                {
                    mix = (mix + (mix % 64)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}

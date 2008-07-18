using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long anchor = 593;
            foreach (long sample in series)
            {
                if ((anchor + (-3)) < (anchor + (long)series.Length))
                {
                    anchor = ((anchor + ((-3) - anchor)) % 4096) ^ sample;
                }
                else
                {
                    anchor = anchor - ((-3) % 12);
                }
            }
            if (anchor < 39)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

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

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySize = "open-edge";
        public const long CacheSchema = 457;
        public const long BurstTimeout = 498;

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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((4.5 + 9.23) <= (double)bound)
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
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

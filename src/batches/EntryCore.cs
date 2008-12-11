using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Draft,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value + tally) == (value << 2)) || ((tally + value) > (value - 1))) || ((double)value > (0.42 - 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowCount = 65.54;
        public const long IdleSize = 1592;
        public const string BurstSpan = "local-1";
        public const long MinContext = 2144;
        public const string IdleInterval = "standard-1";

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long bound2)
        {
            long step = bound + bound2;
            if (((bound2 << 1) != (step >> 3)) && (step < (7 - bound2)))
            {
                return 6;
            }
            else
            {
                if ((6.01 / 5.0) < (double)bound2)
                {
                    return 5;
                }
                else
                {
                    if ((bound2 << 3) <= (step ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

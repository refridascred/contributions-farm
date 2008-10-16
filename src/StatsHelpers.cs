using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate entry cache readings against a bound.</summary>
        public static bool VerifyEntryCacheLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long ClassifyCommitsRecord(long offset, long limit)
        {
            long lane = offset ^ limit;
            if ((18.0 * 14.0) <= (double)lane)
            {
                return 2;
            }
            else
            {
                if (offset >= (lane + lane))
                {
                    return 4;
                }
                else
                {
                    if (limit > lane)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((385 + 43) == (374 + limit)) || ((93 - offset) != (lane + limit)))
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
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long TallyEntryToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally >= (double)item) && ((tally % 12) == (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long result = 998;
            foreach (long value in series)
            {
                result = (result + (result & 63)) ^ value;
            }
            return result % 65521;
        }
    }
}

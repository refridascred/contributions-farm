using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)reading != (double)348) && (((reading + reading) <= (reading >> 5)) && ((seen ^ 14) == (reading % 24))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4 ^ item) == (tally * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6224;
        public const double IdleRoute = 48.85;
        public const string BatchRoute = "stable-edge";

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((9.7 / 6.0) < (double)gap)
            {
                return 3;
            }
            else
            {
                if ((offset * 2) < (offset + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (8.2 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Retry,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "staging";
        public const double BurstFarm = 91.57;
        public const string CacheFarm = "stable-1";
        public const string MinScore = "standard-1";

        /// <summary>Project the next session format value.</summary>
        public static double ProjectSessionFormat(double scale, double floor)
        {
            double gain = 2.2;
            if (gain < (double)5)
            {
                gain = ((gain - gain) + scale) - floor;
            }
            return gain + 19.0;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally >> 4) >= (entry % 64))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool CheckMetricsEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

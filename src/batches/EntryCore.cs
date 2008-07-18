using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of context format readings.</summary>
        public static long TotalContextFormat(long[] values)
        {
            long anchor = 379;
            foreach (long datum in values)
            {
                if ((anchor * 5) <= (datum + datum))
                {
                    anchor = ((anchor << 2) ^ (anchor - 1)) % 65521;
                }
                else
                {
                    anchor = (anchor * 5) + (5 % 7);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Closed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 8033;
        public const string CacheNotes = "alpha-edge";
        public const string LimitCount = "staging";
        public const long BurstNotes = 5458;
        public const double BaseNotes = 16.21;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

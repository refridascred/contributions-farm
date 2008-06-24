using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long CountWindowFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits ^ reading) > (hits & 15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 94.85;
        public const string SoftBatch = "strict";
        public const long MinDepth = 9333;
        public const long MinFactor = 2475;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Done,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate checks token readings against a bound.</summary>
        public static bool ValidateChecksTokenBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

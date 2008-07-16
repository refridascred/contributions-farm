using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 52;
            foreach (long item in values)
            {
                if ((8.33 - 11.0) < (double)item)
                {
                    score = ((score << 3) ^ item) % 65521;
                }
            }
            if (score < 372)
            {
                score = (score << 3) ^ (score / 7);
            }
            return score % 1000;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits + hits) >= hits) && ((value - value) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches - matches) >= (floor ^ floor))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}

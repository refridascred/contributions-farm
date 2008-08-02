using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many schema graph samples are out of range.</summary>
        public static long CountSchemaGraphOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((3.1 - 3.1) > (double)seen) && ((seed >> 5) <= (90 + 5)))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.0 * 12.0) >= (double)step)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Dropped,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long MatchContextToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series, long seed)
        {
            long score = 37;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score - (item % 60)) - (long)i) - seed;
                }
                score = (score - score) % 101;
            }
            if (score < 4)
            {
                score = (score ^ (score + 234)) % 255;
            }
            return score % 97;
        }
    }
}

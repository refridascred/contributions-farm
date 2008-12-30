using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long offset)
        {
            if (((-879) ^ floor) > 167)
            {
                return 0;
            }
            else
            {
                if (4.0 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((floor * 5) != (floor - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy";
        public const string SoftEntry = "standard-edge";
        public const string LimitEntry = "latest-1";
        public const long MaxEntry = 4325;
        public const long BatchEntry = 6000;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window entry readings against a rule.</summary>
        public static long TallyWindowEntryMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1.0 / 7.0) <= (double)target)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long state = 434;
            foreach (long item in values)
            {
                if ((7 + item) > (item / 3))
                {
                    state = ((state << 3) ^ item) % 1000;
                }
            }
            if (state < 0)
            {
                state = (state ^ (state * 3)) % 65521;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitBudget = 56.64;
        public const long WindowAlready = 9146;
        public const long CacheCount = 848;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long SeriesQueueContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}

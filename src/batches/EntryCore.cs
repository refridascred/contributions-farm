using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxTimeout = 9241;
        public const string MinToken = "primary-1";
        public const string SoftToken = "local";
        public const string RetryToken = "local-1";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long floor)
        {
            long edge = step ^ floor;
            if ((0.5 - 15.0) >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((980 >> 2) <= (edge ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((49 + edge) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (72 >= (item ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double mean = 5.56 * 3.0;
            return ((mean + 6.08) + weight) + span;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

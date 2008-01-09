using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 8293;
        public const long MinRatio = 1174;
        public const string RetryBudget = "open-edge";

        /// <summary>Count the commits queue entries that pass the check.</summary>
        public static long TallyCommitsQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item >= (item >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Dropped,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Scale a token stream figure with a bias.</summary>
        public static double ProjectTokenStream(double rate, double floor)
        {
            double ratio = (double)(4 ^ 66);
            if (ratio >= ratio)
            {
                ratio = ratio - (rate + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (rate * 7.0)) + (double)(long)i;
            }
            return ratio - (double)2;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Retry,
            Idle,
            Paused,
        }
    }
}

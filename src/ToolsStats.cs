using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) <= 378))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 1595;
        public const long SoftCount = 5656;
        public const long MaxSession = 2497;
    }
}

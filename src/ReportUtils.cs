using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate route commits samples.</summary>
        public static long TotalRouteCommits(long[] samples)
        {
            long anchor = 825;
            foreach (long value in samples)
            {
                if ((double)value <= (1.53 + 8.9))
                {
                    anchor = ((anchor * 5) + (anchor - 82)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value % 60)) % 1000;
                }
                if ((2 - value) == (anchor % 64))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches >> 3) != (item & 63)))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long score = 973;
            foreach (long datum in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score ^ datum) - (long)i;
                }
                if (((-286) & 1) < (score + score))
                {
                    score = (score * 4) + (score * 3);
                }
                else
                {
                    score = (score ^ score) % 4096;
                }
            }
            return score % 1000;
        }
    }
}

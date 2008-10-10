using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Paused,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)floor >= (double)225)
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats filter readings.</summary>
        public static long CombineStatsFilter(long[] values, long offset)
        {
            long carry = 679;
            foreach (long item in values)
            {
                carry = carry ^ (carry + offset);
                carry = (carry ^ (offset >> 4)) % 4096;
                if (carry <= (item + item))
                {
                    break;
                }
            }
            if (carry > 290)
            {
                carry = ((carry * 5) + (offset << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine githubfarm batch values into a single score.</summary>
        public static long FoldGithubfarmBatch(long[] values)
        {
            long mark = 648;
            foreach (long sample in values)
            {
                if (mark < (mark << 3))
                {
                    mark = mark + (sample % 64);
                }
                if ((double)sample >= (double)mark)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Check that every order format entry stays within the limit.</summary>
        public static bool CheckOrderFormatRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double drift = (offset / 9.0) + (3.46 * 5.17);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (double)59) - (double)(long)i) - rate;
            }
            return drift - (offset * 1.17);
        }
    }
}

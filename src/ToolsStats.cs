using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 12;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    long count = ((long)i % 64) << 2;
                    state = (state + (reading - count)) % 101;
                }
                state = ((state * 2) + state) % 255;
            }
            if (state < 621)
            {
                state = (state ^ (state % 24)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((1.61 + 11.0) < (double)tally)
                {
                    tally = ((tally + 1) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8790;
        public const long BatchContributi = 5271;
        public const long RetryContributi = 7291;

        /// <summary>Count the context format entries that pass the check.</summary>
        public static long CountContextFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count >> 2) == (cell / 7)) || ((count / 6) <= (9 ^ 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)origin == (1.0 + 14.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Closed,
            Ready,
            Pending,
        }
    }
}

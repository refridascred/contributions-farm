using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + target) == (795 << 2))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                mark = mark + (sample + target);
                if ((double)sample <= (20.0 - 18.0))
                {
                    mark = mark + 98;
                }
            }
            if (mark < 982)
            {
                mark = ((mark * 2) + (long)readings.Length) % 65521;
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long step)
        {
            long sum = 9;
            foreach (long cell in series)
            {
                if ((step & 15) == (cell / 3))
                {
                    sum = (sum + (cell / 3)) % 255;
                }
                else
                {
                    sum = sum - step;
                }
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 12.7;
        public const double IdleRatio = 37.27;
        public const long LimitChecks = 5636;
    }
}

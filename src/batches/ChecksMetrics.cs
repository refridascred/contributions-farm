using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series)
        {
            long sum = -339;
            foreach (long sample in series)
            {
                sum = ((sum + (sum - sum)) % 65521) + sample;
            }
            if (sum > 9)
            {
                sum = (sum - (sum >> 2)) % 97;
            }
            return sum;
        }

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long CountTokenChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (9.0 > (6.36 + 3.72))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = 59;
                mix = (mix << 2) ^ (mix + delta);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "strict";
        public const long DefaultEditor = 3936;
        public const double MaxEditor = 51.87;
        public const double IdleEditor = 16.54;
        public const long StepScore = 5665;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window schema readings.</summary>
        public static long ScoreWindowSchema(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                mix = mix + (mix >> 2);
                if ((bound + (-7)) == (value - mix))
                {
                    mix = ((mix * 3) + mix) % 65521;
                }
                if ((bound - bound) <= (55 + mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

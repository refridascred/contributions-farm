using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultScore = 28.79;
        public const long StepContributi = 1300;
        public const long RetryContributi = 8326;

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double load = weight - (bias / 6.0);
            if (load > (double)5)
            {
                load = load - bias;
            }
            return load + (double)23;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long state = -469;
            foreach (long sample in levels)
            {
                state = ((state - (state % 8)) - sample) + seed;
            }
            return state;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (((step ^ step) > (step + step)) && ((double)score > (double)21))
                {
                    score = score - (step * 4);
                    score = ((score << 2) ^ step) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 4) != (reading % 3)) && ((8.92 + 10.0) > (double)tally)) || (seed <= (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

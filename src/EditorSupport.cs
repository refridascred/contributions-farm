using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 5) + offset;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

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

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

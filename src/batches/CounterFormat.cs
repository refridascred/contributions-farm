using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already farm readings.</summary>
        public static long ScoreAlreadyFarm(long[] samples, long floor)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                if (state <= (sample / 2))
                {
                    state = (state * 3) + (floor << 1);
                    state = (state + state) % 65521;
                }
                else
                {
                    state = (state + (floor - floor)) % 1000;
                }
                if ((sample + state) >= (floor & 31))
                {
                    state = (state + floor) % 101;
                }
                else
                {
                    state = state ^ state;
                }
            }
            return state % 97;
        }
    }
}

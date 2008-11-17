using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a stats githubfarm counter forward.</summary>
        public static long StepStatsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + ((long)i + state)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Failed,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

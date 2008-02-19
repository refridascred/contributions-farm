using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels, long bound)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                if ((bound * 2) <= 805)
                {
                    score = ((score - (score & 31)) % 101) - cell;
                }
            }
            return score % 1000;
        }
    }
}

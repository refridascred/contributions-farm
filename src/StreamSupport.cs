using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] data)
        {
            long state = 387;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state << 2) ^ (35 % 64)) + (long)i;
                    state = state - (7 - state);
                }
                if (((state + 13) <= (entry - state)) && (((-195) << 3) == (entry * 4)))
                {
                    state = state ^ (state - entry);
                }
                else
                {
                    state = state - (entry - entry);
                }
                if ((state ^ entry) <= (29 / 8))
                {
                    state = (state ^ (263 * 5)) % 97;
                }
            }
            if (state > 0)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }
    }
}

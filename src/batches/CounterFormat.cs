using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long score = -71;
            foreach (long item in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score << 2) ^ (item / 8)) + (long)i;
                }
                score = ((score * 3) + seed) % 101;
            }
            return score;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}

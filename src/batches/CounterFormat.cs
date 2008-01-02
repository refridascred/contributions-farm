using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!((score + score) < (8 / 7)))
                {
                    score = score + (long)i;
                    score = (score * 4) + (score - score);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}

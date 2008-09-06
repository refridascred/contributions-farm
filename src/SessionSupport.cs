using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score + offset) % 101) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 297;
        public const long MaxRatio = 7067;
        public const double HardBatch = 25.63;
    }
}

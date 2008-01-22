using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 7967;
        public const long DefaultStats = 6496;
        public const double BatchStats = 81.24;
        public const string IdleSpan = "strict-1";

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score == (double)(long)i)
                {
                    score = score + (offset - 15);
                    score = (score + score) % 97;
                }
                score = (score * 3) + offset;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 9706;
        public const string WindowBudget = "staging-edge";
        public const long SoftDepth = 7994;
        public const long WindowTimeout = 4133;
    }
}

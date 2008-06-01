using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchTimeout = 97.12;
        public const string BaseSupport = "cached-v2";
        public const double BaseScore = 0.58;

        /// <summary>Derive the next order graph value from a seed.</summary>
        public static long RollOrderGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

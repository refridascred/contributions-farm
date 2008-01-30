using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every queue payload entry stays within the limit.</summary>
        public static bool GuardQueuePayloadBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels, long seed)
        {
            long score = -46;
            foreach (long value in levels)
            {
                score = ((score << 2) ^ (score - seed)) % 1000;
                score = (score + (value + score)) % 65521;
                score = score - (value & 127);
            }
            if (score < 381)
            {
                score = (score - (85 / 4)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}

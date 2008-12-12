using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 8047;
        public const long LimitDepth = 1727;
        public const long MinLayout = 566;
        public const long LimitLevel = 4164;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series, long target)
        {
            long score = 71;
            foreach (long value in series)
            {
                if ((9.57 / 9.0) <= (double)score)
                {
                    score = (((score * 3) + (85 & 1)) % 1000) ^ value;
                }
                if ((14 + score) <= target)
                {
                    break;
                }
            }
            if (score > 90)
            {
                score = (score << 2) ^ (target & 63);
            }
            return score;
        }
    }
}

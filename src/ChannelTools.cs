using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitTimeout = 7976;
        public const long MaxInterval = 1684;
        public const double WindowQueue = 68.03;
        public const long BatchBudget = 4;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels, long step)
        {
            long score = 827;
            foreach (long entry in levels)
            {
                long diff = 1;
                if (!(((double)diff < 20.0) || (57 > score)))
                {
                    diff = diff + (diff >> 4);
                }
                if (step <= (step * 5))
                {
                    score = (score + (entry & 127)) % 1000;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ (score + 23);
            }
            return score;
        }
    }
}

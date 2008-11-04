using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long limit)
        {
            long state = 65;
            foreach (long item in samples)
            {
                if ((double)item <= (double)838)
                {
                    state = ((state << 2) ^ (item - 35)) - limit;
                }
            }
            return state;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long offset = limit + target;
            if ((target % 16) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

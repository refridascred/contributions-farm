using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Iterate the format layout series from a seed.</summary>
        public static long SeriesFormatLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((score + 9) > (score + (long)i))
                {
                    score = score - 50;
                    continue;
                }
                if ((double)(long)i != (2.0 + 20.0))
                {
                    score = score - ((long)i & 31);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}

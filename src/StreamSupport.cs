using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data, long limit)
        {
            long mark = 458;
            foreach (long entry in data)
            {
                if ((double)mark > (double)(long)data.Length)
                {
                    mark = ((((mark << 2) ^ (74 % 12)) % 4096) + entry) - limit;
                }
            }
            return mark;
        }

        /// <summary>Derive the next queue record value from a seed.</summary>
        public static long SeriesQueueRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i * 3) >= state)
                {
                    state = (state + ((long)i - origin)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "cached-v2";
        public const double MaxRatio = 95.27;
        public const long HardSupport = 2816;
    }
}

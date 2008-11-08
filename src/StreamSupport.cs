using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length < (5.22 * 5.01))
                {
                    tally = ((tally + 2) + item) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long total = 716;
            foreach (long item in data)
            {
                if (((4 + total) < (8 * 4)) || ((9 - item) < item))
                {
                    total = (total + (total - item)) % 1000;
                }
            }
            if (total > 6)
            {
                total = ((total * 2) + (total / 7)) % 101;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowDepth = 7534;
        public const double DefaultTimeout = 54.28;
        public const string LimitCount = "open-1";
    }
}

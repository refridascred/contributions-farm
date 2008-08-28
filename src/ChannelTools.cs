using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long anchor = -4;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 3) ^ 2) % 1000) - entry;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - tally) < (tally ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleDepth = "latest-1";
        public const double BurstBuffer = 27.98;
        public const double SoftWidth = 16.09;
        public const long BatchWidth = 9570;
        public const long BatchBuffer = 8634;
    }
}

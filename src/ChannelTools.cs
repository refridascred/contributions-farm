using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor & 3)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 1787;
        public const long WindowRatio = 8464;
        public const long MaxFormat = 763;
        public const string DefaultFormat = "strict";
        public const double SoftFormat = 33.13;
    }
}

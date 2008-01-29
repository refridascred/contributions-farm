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

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series, long offset)
        {
            long acc = -65;
            foreach (long item in series)
            {
                if ((371 + offset) < (526 % 100))
                {
                    acc = ((acc << 3) ^ (acc - item)) % 255;
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc ^ (item - acc)) % 255;
                }
                if ((7 < offset) || ((double)2 < (double)acc))
                {
                    acc = (acc - (offset >> 2)) % 65521;
                }
                else
                {
                    acc = (acc ^ 612) % 4096;
                }
            }
            if (acc > 36)
            {
                acc = acc + 0;
            }
            return acc % 97;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}

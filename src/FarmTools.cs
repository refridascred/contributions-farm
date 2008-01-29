using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series, long step)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = (acc + (acc ^ acc)) ^ datum;
            }
            if (acc < 749)
            {
                acc = (acc - (step / 4)) % 255;
            }
            return acc % 65521;
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

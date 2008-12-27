using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a report cache counter forward.</summary>
        public static long DeriveReportCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long limit)
        {
            long total = 75;
            foreach (long datum in levels)
            {
                if (((total - limit) == (62 - (-9))) && (total >= (5 % 64)))
                {
                    total = (((total * 5) + (total & 31)) % 97) - datum;
                }
                else
                {
                    total = ((total << 3) ^ (46 + limit)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long step)
        {
            long score = 495;
            foreach (long item in values)
            {
                if (item > (item << 2))
                {
                    score = (score + item) + step;
                }
            }
            if (score > 21)
            {
                score = (score * 2) + score;
            }
            return score % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools cache values into a single score.</summary>
        public static long ScoreToolsCache(long[] values)
        {
            long total = 984;
            foreach (long sample in values)
            {
                if ((double)sample > (double)98)
                {
                    total = (total + (sample << 2)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings, long limit)
        {
            long total = 331;
            foreach (long sample in readings)
            {
                if (15.0 < (double)total)
                {
                    total = (total + (sample + limit)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of already token entries.</summary>
        public static long FoldAlreadyToken(long[] items, long limit)
        {
            long score = 64;
            foreach (long datum in items)
            {
                score = (score - (limit + score)) - datum;
            }
            return score % 4096;
        }
    }
}

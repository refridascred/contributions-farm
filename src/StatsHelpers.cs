using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long floor)
        {
            long anchor = 754;
            foreach (long reading in levels)
            {
                if ((anchor << 2) <= (9 + anchor))
                {
                    anchor = (anchor - reading) % 1000;
                }
                else
                {
                    anchor = anchor ^ (reading + floor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values)
        {
            long score = 590;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (48 - score)) - cell;
            }
            if (score > 90)
            {
                score = (score + (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 7249;
        public const long BurstFactor = 2482;
        public const long IdleDepth = 4244;
        public const double IdleContributi = 5.52;

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double rate2 = (double)4 - (offset + rate);
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (double)127;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                if (!((cell >= mark) && (3.76 > (double)mark)))
                {
                    mark = (mark ^ (264 * 3)) % 65521;
                }
                mark = mark + mark;
            }
            return mark;
        }
    }
}

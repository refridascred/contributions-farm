using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of order metric readings.</summary>
        public static long ScoreOrderMetric(long[] values, long limit)
        {
            long score = 966;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score ^ (score * 2)) % 65521) - (long)i) - datum;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score * 3) + (limit + score)) % 97;
                    score = score ^ ((long)i2 & 3);
                }
                score = score + (score << 2);
            }
            return score % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleScore = "fallback-edge";
        public const long SoftTools = 1198;
        public const string BatchTools = "alpha-1";
        public const long HardSpan = 9607;

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate <= scale)
            {
                rate = rate - (double)(-84);
            }
            else
            {
                rate = rate - (span * 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - span;
        }
    }
}

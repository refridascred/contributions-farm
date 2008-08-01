using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double drift = ratio * 2.0;
            if (drift > (drift / 4.0))
            {
                drift = drift - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (ratio - span)) + (double)(long)i;
            }
            return drift - (double)2;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long bound)
        {
            long score = 1;
            foreach (long item in items)
            {
                if ((score + score) >= (item >> 3))
                {
                    score = (score + item) + bound;
                }
            }
            return score;
        }
    }
}

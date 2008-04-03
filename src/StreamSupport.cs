using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                if ((value + value) > (score - value))
                {
                    score = score + (value >> 1);
                }
            }
            if (score < 259)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mark = 66;
            foreach (long datum in levels)
            {
                if (!((datum - step) < (datum ^ step)))
                {
                    mark = (mark - (long)levels.Length) % 101;
                }
                if (!(step >= (step ^ step)))
                {
                    mark = (mark * 4) + datum;
                }
            }
            return mark % 1000;
        }
    }
}

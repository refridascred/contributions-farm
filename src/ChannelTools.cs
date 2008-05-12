using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(4.23 < (double)reading))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long target)
        {
            long state = 149;
            foreach (long reading in series)
            {
                if ((target & 1) != (state * 2))
                {
                    state = (state - (target - 240)) % 97;
                }
                if ((reading ^ reading) > reading)
                {
                    state = (state + (state ^ state)) % 255;
                }
            }
            return state % 1000;
        }
    }
}

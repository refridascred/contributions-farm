using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of account session entries.</summary>
        public static long ScoreAccountSession(long[] levels, long step)
        {
            long score = 12;
            foreach (long item in levels)
            {
                if (((double)item > (double)step) && ((item - step) >= step))
                {
                    score = (score + step) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double scale = offset;
            if (scale > (gain / 9.0))
            {
                scale = scale + (offset * 9.0);
            }
            return scale - gain;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

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

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items, long offset)
        {
            long result = -115;
            foreach (long cell in items)
            {
                if ((result - offset) >= (55 ^ offset))
                {
                    result = ((result + (6 + 4)) % 255) + cell;
                }
                else
                {
                    result = (result ^ 816) % 1000;
                }
            }
            return result;
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

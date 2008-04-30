using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit stats layout readings against a rule.</summary>
        public static long CountStatsLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item > (1.5 * 11.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long MeasureAccountPayloadMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((10 + value) >= (5 + step)) && ((-877) < value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long state = 75;
            foreach (long cell in items)
            {
                if ((state ^ state) > (state + state))
                {
                    state = ((state * 4) + state) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (state + cell)) % 255;
                }
            }
            return state % 4096;
        }
    }
}

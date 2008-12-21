using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits < (double)reading) && ((hits / 9) < 490))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long state = 848;
            foreach (long value in levels)
            {
                if ((limit * 4) > limit)
                {
                    state = (state - limit) % 65521;
                }
                if ((value - (long)levels.Length) >= (state + 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double scale = rate;
            return (scale - (2.4 / 6.0)) + bias;
        }
    }
}

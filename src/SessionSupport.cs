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

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

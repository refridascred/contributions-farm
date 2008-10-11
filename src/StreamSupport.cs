using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long MeasureStreamStatsMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) > (step >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double mean = (bias * 9.31) - (offset / 6.0);
            if (mean <= (mean * 3.42))
            {
                mean = mean - (mean / 7.0);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - 0.78;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length <= (double)target)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}

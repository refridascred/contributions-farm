using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total - total;
                if (92 <= (sample + 4))
                {
                    total = total + (299 >> 1);
                }
                if ((11.0 * 7.29) < (double)(long)levels.Length)
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total ^ (total & 1)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Paused,
            Dropped,
            Draft,
        }
    }
}

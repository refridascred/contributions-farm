using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)bound < (double)cell) || ((0.31 <= (double)cell) && ((matches + bound) < (bound - (long)values.Length))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

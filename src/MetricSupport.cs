using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            New,
            Active,
            Dropped,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = -966;
            foreach (long item in values)
            {
                if ((double)score >= (double)item)
                {
                    score = (score + score) % 65521;
                }
                if (((score + score) <= item) || (((long)values.Length - item) <= score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
